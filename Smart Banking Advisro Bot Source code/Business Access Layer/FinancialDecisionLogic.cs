using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Banking_Advisor_bot.Data_Access_Layer;
using Banking_Advisor_bot.Business_objects;
using System.Data;
using System.Data.SqlClient;

namespace Banking_Advisor_bot.Business_Access_Layer
{
    public class FinancialDecisionLogic
    {
        ExpenseTypes expenseT = new ExpenseTypes();
        ExpensePlan_resultDAL expDAL = new ExpensePlan_resultDAL();
        ExpensesDAL expenseD = new ExpensesDAL();
        IncomeDAL incomeD = new IncomeDAL();
        IncomeSourceBO incomeB = new IncomeSourceBO();
        ExpensesBO expenseB = new ExpensesBO();
        updateThreshold upTH = new updateThreshold();
        FinancialPlanResult planResult1 = new FinancialPlanResult();
        FinancialPlan_computation planCompute = new FinancialPlan_computation();
        FinancialDecisionBO financialD = new FinancialDecisionBO();
        
        decimal[] arrExpense = new decimal[10];
        decimal[] arrexpenseneg = new decimal[10];
        string[] arrexpName = new string[10];
        string[] arrexpName1 = new string[10];
        decimal[] result = new decimal[10];

        int i = 0, m = 0,size=0;
        decimal totalIncome, basicSaving = (decimal)34.00, savingRemain;
        decimal houseHoldTH = (decimal)23.00;
        decimal healthTH = (decimal)14.00;
        decimal educationTH = (decimal)10.00;
        decimal travelTH = (decimal)10.00;
        decimal lifestyleTH = (decimal)9.00;
        decimal sum = 0, temp;
         decimal savingdiff =(decimal)0.0; 

        

   
        public void thresholdDifference()
        {
            decimal household_diff = expenseT.householdActual_percentage - expenseT.householdTh;
            if (household_diff > 0)
            {
                arrExpense[i] = household_diff;
                arrexpName[i] = "Household";
                i++;
            }
            else if (household_diff <= 0)
            {
                arrexpenseneg[m] = Math.Abs(household_diff);
                arrexpName1[m] = "Household";
                m++;
            }
            decimal health_diff = expenseT.healthActual_percentage - expenseT.healthTh;
            if (health_diff > 0)
            {
                arrExpense[i] = health_diff;
                arrexpName[i] = "Health";
                i++;
            }
            else if (health_diff <= 0)
            {
                arrexpenseneg[m] = Math.Abs(health_diff);
                arrexpName1[m] = "Health";
                m++;
            }
            decimal education_diff = expenseT.educationActual_percentage - expenseT.educationTH;
            if (education_diff > 0)
            {
                arrExpense[i] = education_diff;
                arrexpName[i] = "Education";
                i++;
            }
            else if (education_diff <= 0)
            {
                arrexpenseneg[m] = Math.Abs(education_diff);
                arrexpName1[m] = "Education";
                m++;
            }
            decimal travel_diff = expenseT.travelActual_percentage - expenseT.travelTH;
            if (travel_diff > 0)
            {
                arrExpense[i] = travel_diff;
                arrexpName[i] = "Travel";
                i++;
            }
            else if (travel_diff <= 0)
            {
                arrexpenseneg[m] = Math.Abs(travel_diff);
                arrexpName1[m] = "Travel";
                m++;
            }
            decimal lifestyle_diff = expenseT.lifestyleActual_percentage - expenseT.lifestyleTH;
            if (lifestyle_diff > 0)
            {
                arrExpense[i] = lifestyle_diff;
                arrexpName[i] = "Lifestyle";
                i++;
            }
            else if (lifestyle_diff <= 0)
            {
                arrexpenseneg[m] = Math.Abs(lifestyle_diff);
                arrexpName1[m] = "Lifestyle";
                m++;
            }
            size = i;
            Array.Sort(arrExpense, arrexpName);
            Array.Reverse(arrExpense);
            Array.Reverse(arrexpName);
            for (int j = 0; j < size; j++)
            {
                result[i] = arrExpense[i];
            }
        }
        public FinancialDecisionBO financialDecision(string loanType, decimal loanAmount,int targetMonths, decimal interestRate)
        {

            expenseB = expenseD.GetExpenseDetail();
            incomeB = incomeD.GetIncomeDetail();
            expenseT = planCompute.InsertExpenseManage(expenseB, incomeB);
            totalIncome = incomeB.bankAccount + incomeB.jobIncome + incomeB.rentalIncome + incomeB.retirementPension + incomeB.socialSecurity + incomeB.otherSources;
            decimal saving_value = (totalIncome * 34) / 100;
            decimal lastMonthexpense= expenseT.householdActual_value+expenseT.healthActual_value+expenseT.educationActual_value+expenseT.travelActual_value+expenseT.lifestyleActual_value;
            decimal lastMonthexppercentage= (lastMonthexpense/totalIncome)*100;
            decimal lastMonthSavingAmount= totalIncome-lastMonthexpense;
            decimal lastMonthSavingPercentage = 100 - lastMonthexppercentage;
            decimal maximum_saving= (totalIncome*50)/100;
                      
            decimal totalMonths = (decimal)(loanAmount / saving_value);
            decimal annualinterestAmount= (decimal)(loanAmount*(interestRate/100))/12;
            decimal interestAmount = (decimal)annualinterestAmount*targetMonths;
            decimal totalTargetLoanAount = loanAmount+ interestAmount;
            decimal loanEMI = totalTargetLoanAount / targetMonths;
            decimal loanEMIpercentage= (loanEMI/totalIncome)*100;
            financialD.targetMonths1 = targetMonths;
            financialD.interestRate = interestRate;
            financialD.totalAmountwithInterest = totalTargetLoanAount;
            financialD.EMIamount = loanEMI;
            
            
            if ((decimal)34.00 < loanEMIpercentage && loanEMIpercentage<=(decimal)50.00 ) //More saving required for payignloan EMI
            {
               
                planResult1 = planCompute.financialPlanResult();
                decimal total = loanEMIpercentage - (decimal)34.00;
                financialD.savingDiffPercentage = total;
                financialD.savingDiffAmount = (total * totalIncome) / 100;
                decimal estHouseholdTH = expenseT.householdTh - (decimal)(((decimal)((expenseT.householdTh / 66)*100) * total) / 100);
                expenseT.householdTh=estHouseholdTH;
                decimal estHealthTH = expenseT.healthTh - (decimal)(((decimal)((expenseT.healthTh/66)*100) * total) / 100);
                expenseT.healthTh=estHealthTH;
                decimal estEducationTH = expenseT.educationTH - (decimal)(((decimal)((expenseT.educationTH/66)*100) * total) / 100);
                expenseT.educationTH=estEducationTH;
                decimal estTravelTH = expenseT.travelTH - (decimal)(((decimal)((expenseT.travelTH/66)*100) * total) / 100);
                expenseT.travelTH=estTravelTH;
                decimal estLifestyleTH = expenseT.lifestyleTH - (decimal)(((decimal)((expenseT.lifestyleTH/66)*100) * total) / 100);
                expenseT.lifestyleTH=estLifestyleTH;
               
                thresholdDifference();

                decimal totalExpensePercentage = expenseT.householdActual_percentage + expenseT.healthActual_percentage + expenseT.educationActual_percentage + expenseT.travelActual_percentage + expenseT.lifestyleActual_percentage;
                decimal savingdiff = basicSaving - (100 - totalExpensePercentage);
                decimal totalTH= expenseT.householdTh+expenseT.healthTh+expenseT.educationTH+expenseT.lifestyleTH+expenseT.travelTH;
                savingRemain = totalTH - totalExpensePercentage;
            

                   i = 0;
               
            for (int n = 0; n < m; n++)                 //adjusting priority expense types percentages 
            {
                // temp= arrexpenseneg[n];
                while (arrexpenseneg[n] != 0)
                {
                    for (int l = 0; l < size; l++)
                    {
                        if (arrExpense[l] >= arrexpenseneg[n])
                        {
                            arrExpense[l] = arrExpense[l] - arrexpenseneg[n];
                            arrexpenseneg[n] = 0;
                        }
                        else if (arrExpense[l] < arrexpenseneg[n] && arrExpense[l] != 0)
                        {
                            arrexpenseneg[n] = arrexpenseneg[n] - arrExpense[l];
                            arrExpense[l] = 0;

                        }
                    }
                    savingRemain = savingRemain - arrexpenseneg[n];
                    arrexpenseneg[n] = 0;


                }
            }
            for (int p = 0; p < size; p++)               //Adding remaining percentages of all types of expenses to basic saving percentages
            {
                if (arrExpense[p] > 0)
                {
                    basicSaving = basicSaving + arrExpense[p];
                    //arrExpense[p]=0;
                }
            }

            UpdatingExpenses(arrExpense,arrexpName,arrexpenseneg,arrexpName1);
          
        }
            else if ((decimal)34.00 >= loanEMIpercentage ) //Loan EMI amount getting save easily
            {
                if (loanEMIpercentage > lastMonthSavingPercentage && lastMonthSavingPercentage<(decimal)34.00) //User need to save more amount as compare to last month and he/she may follow ideal financial plan
                {

                    decimal total = loanEMIpercentage-lastMonthSavingPercentage;
                    financialD.savingDiffPercentage = total;
                   
                    financialD.savingDiffAmount = (total * totalIncome) / 100;
                    thresholdDifference();

                    i = 0;

                    while (total != 0)
                    {
                        if (arrExpense[i] >= total)
                        {
                            arrExpense[i] = arrExpense[i] - total;
                            total = 0;
                        }
                        else if (arrExpense[i] < total)
                        {
                            total = total - arrExpense[i];
                            arrExpense[i] = 0;
                            i++;

                        }
                    }
                    financialDecisionCompute(total);
                }
                else if (lastMonthSavingPercentage >= loanEMIpercentage && lastMonthSavingPercentage <= (decimal)34.00)// saving is enough to pay EMI of loan but user may follow ideal financial plan
                {
                    decimal total = (decimal)34.00 - lastMonthSavingPercentage;
                    financialD.savingDiffPercentage = (decimal)0.00;

                    financialD.savingDiffAmount = (decimal)0.00;
                    thresholdDifference();
                    financialDecisionCompute(total);
                }
                    planResult1= UpdatingExpenses(arrExpense, arrexpName, arrexpenseneg, arrexpName1);

            }
            
            expDAL.UpdateExpense_PlanResult(planResult1);
            return financialD;
        }

        public void financialDecisionCompute(decimal difference)
        {
            
            

            decimal totalExpensePercentage = expenseT.householdActual_percentage + expenseT.healthActual_percentage + expenseT.educationActual_percentage + expenseT.travelActual_percentage + expenseT.lifestyleActual_percentage;
            //decimal savingdiff = basicSaving - (100 - totalExpensePercentage);
            savingRemain = 66 - totalExpensePercentage;



            for (int n = 0; n < m; n++)                 //adjusting priority expense types percentages 
            {
                // temp= arrexpenseneg[n];
                while (arrexpenseneg[n] != 0)
                {
                    for (int l = 0; l < size; l++)
                    {
                        if (arrExpense[l] >= arrexpenseneg[n])
                        {
                            arrExpense[l] = arrExpense[l] - arrexpenseneg[n];
                            arrexpenseneg[n] = 0;
                        }
                        else if (arrExpense[l] < arrexpenseneg[n] && arrExpense[l] != 0)
                        {
                            arrexpenseneg[n] = arrexpenseneg[n] - arrExpense[l];
                            arrExpense[l] = 0;

                        }
                    }
                    savingRemain = savingRemain - arrexpenseneg[n];
                    arrexpenseneg[n] = 0;


                }
            }
            for (int p = 0; p < size; p++)               //Adding remaining percentages of all types of expenses to basic saving percentages
            {
                if (arrExpense[p] > 0)
                {
                    basicSaving = basicSaving + arrExpense[p];
                    //arrExpense[p]=0;
                }
            }
        }
        public FinancialPlanResult UpdatingExpenses(decimal[] arrExpense, string[] arrexpName, decimal[] arrexpenseneg, string []arrexpName1)
        {
            for (int u = 0; u < size; u++)
            {
                string value = arrexpName[u];

                switch (value)
                {
                    case "Household":
                        {
                            if (arrExpense[u] > 0)
                            {
                                planResult1.householdPlan_percentage = (decimal)expenseT.householdTh;
                                planResult1.householdPlan_value = (decimal)(totalIncome * planResult1.householdPlan_percentage) / 100;
                                planResult1.householdSavingPersentages = (decimal)arrExpense[u];
                                planResult1.householdSavingAmount = (decimal)(totalIncome * planResult1.householdSavingPersentages) / 100;
                            }
                            else if (arrExpense[u] == 0)
                            {
                                planResult1.householdPlan_percentage = (decimal)expenseT.householdTh;
                                planResult1.householdPlan_value = (decimal)(totalIncome * planResult1.householdPlan_percentage) / 100;
                                planResult1.householdSavingPersentages = (decimal)0;
                                planResult1.householdSavingAmount = (decimal)0;
                            }

                        }
                        break;
                    case "Health":
                        {
                            if (arrExpense[u] > 0)
                            {
                                planResult1.healthPlan_percentage = (decimal)expenseT.healthTh - arrexpenseneg[u];
                                planResult1.healthPlan_value = (decimal)(totalIncome * planResult1.healthPlan_percentage) / 100;
                                planResult1.healthSavingPersentages = (decimal)arrExpense[u];
                                planResult1.healthSavingAmount = (decimal)(totalIncome * planResult1.healthSavingPersentages) / 100;
                            }
                            else if (arrExpense[u] == 0)
                            {
                                planResult1.healthPlan_percentage = (decimal)expenseT.healthTh - arrexpenseneg[u];
                                planResult1.healthPlan_value = (decimal)(totalIncome * planResult1.healthPlan_percentage) / 100;
                                planResult1.healthSavingPersentages = (decimal)0;
                                planResult1.healthSavingAmount = (decimal)0;
                            }

                        }
                        break;
                    case "Education":
                        {
                            if (arrExpense[u] > 0)
                            {
                                planResult1.educationPlan_percentage = (decimal)expenseT.educationTH - arrexpenseneg[u];
                                planResult1.educationPlan_value = (decimal)(totalIncome * planResult1.educationPlan_percentage) / 100;
                                planResult1.educationSavingPersentages = (decimal)arrExpense[u];
                                planResult1.educationSavingAmount = (decimal)(totalIncome * planResult1.educationSavingPersentages) / 100;
                            }
                            else if (arrExpense[u] == 0)
                            {
                                planResult1.educationPlan_percentage = (decimal)expenseT.educationTH - arrexpenseneg[u];
                                planResult1.educationPlan_value = (decimal)(totalIncome * planResult1.educationPlan_percentage) / 100;
                                planResult1.educationSavingPersentages = (decimal)0;
                                planResult1.educationSavingAmount = (decimal)0;
                            }

                        }
                        break;
                    case "Travel":
                        {
                            if (arrExpense[u] > 0)
                            {
                                planResult1.travelPlan_percentage = (decimal)expenseT.travelTH - arrexpenseneg[u];
                                planResult1.travelPlan_value = (decimal)(totalIncome * planResult1.travelPlan_percentage) / 100;
                                planResult1.travelSavingPersentages = (decimal)arrExpense[u];
                                planResult1.travelSavingAmount = (decimal)(totalIncome * planResult1.travelSavingPersentages) / 100;
                            }
                            else if (arrExpense[u] == 0)
                            {
                                planResult1.travelPlan_percentage = (decimal)expenseT.travelTH - arrexpenseneg[u];
                                planResult1.travelPlan_value = (decimal)(totalIncome * planResult1.travelPlan_percentage) / 100;
                                planResult1.travelSavingPersentages = (decimal)0;
                                planResult1.travelSavingAmount = (decimal)0;
                            }

                        }
                        break;
                    case "Lifestyle":
                        {
                            if (arrExpense[u] > 0)
                            {
                                planResult1.lifestylePlan_percentage = (decimal)expenseT.lifestyleTH - arrexpenseneg[u];
                                planResult1.lifestylePlan_value = (decimal)(totalIncome * planResult1.lifestylePlan_percentage) / 100;
                                planResult1.lifestyleSavingPersentages = (decimal)arrExpense[u];
                                planResult1.lifestyleSavingAmount = (decimal)(totalIncome * planResult1.lifestyleSavingPersentages) / 100;
                            }
                            if (arrExpense[u] == 0)
                            {
                                planResult1.lifestylePlan_percentage = (decimal)expenseT.lifestyleTH - arrexpenseneg[u];
                                planResult1.lifestylePlan_value = (decimal)(totalIncome * planResult1.lifestylePlan_percentage) / 100;
                                planResult1.lifestyleSavingPersentages = (decimal)0;
                                planResult1.lifestyleSavingAmount = (decimal)0;
                            }

                        }
                        break;
                }

            }


            for (int u = 0; u < m; u++)
            {
                string value = arrexpName1[u];

                switch (value)
                {
                    case "Household":
                        {

                            if (arrexpenseneg[u] == 0)
                            {
                                planResult1.householdPlan_percentage = (decimal)expenseT.householdTh;
                                planResult1.householdPlan_value = (decimal)(totalIncome * planResult1.householdPlan_percentage) / 100;
                                planResult1.householdSavingPersentages = (decimal)0;
                                planResult1.householdSavingAmount = (decimal)0;
                            }
                        }
                        break;
                    case "Health":
                        {
                            if (arrexpenseneg[u] == 0)
                            {
                                planResult1.healthPlan_percentage = (decimal)expenseT.healthTh;
                                planResult1.healthPlan_value = (decimal)(totalIncome * planResult1.healthPlan_percentage) / 100;
                                planResult1.healthSavingPersentages = (decimal)0;
                                planResult1.healthSavingAmount = (decimal)0;
                            }
                        }
                        break;
                    case "Education":
                        {
                            if (arrexpenseneg[u] == 0)
                            {
                                planResult1.educationPlan_percentage = (decimal)expenseT.educationTH;
                                planResult1.educationPlan_value = (decimal)(totalIncome * planResult1.educationPlan_percentage) / 100;
                                planResult1.educationSavingPersentages = (decimal)0;
                                planResult1.educationSavingAmount = (decimal)0;
                            }
                        }
                        break;
                    case "Travel":
                        {
                            if (arrexpenseneg[u] == 0)
                            {
                                planResult1.travelPlan_percentage = (decimal)expenseT.travelTH;
                                planResult1.travelPlan_value = (decimal)(totalIncome * planResult1.travelPlan_percentage) / 100;
                                planResult1.travelSavingPersentages = (decimal)0;
                                planResult1.travelSavingAmount = (decimal)0;
                            }
                        }
                        break;
                    case "Lifestyle":
                        {
                            if (arrexpenseneg[u] == 0)
                            {
                                planResult1.lifestylePlan_percentage = (decimal)expenseT.lifestyleTH;
                                planResult1.lifestylePlan_value = (decimal)(totalIncome * planResult1.lifestylePlan_percentage) / 100;
                                planResult1.lifestyleSavingPersentages = (decimal)0;
                                planResult1.lifestyleSavingAmount = (decimal)0;
                            }
                        }
                        break;
                }
            }
            return planResult1;
        }
            
        
        public DataSet BindfinancialData_grid()
        {
            DataSet data = expDAL.getFinancialPlanData();
            return data;
        }
        public DataSet BindfinancialPlan_grid()
        {
            DataSet dataS = expDAL.getFinancialPlanResult();
            return dataS;
        }
    }


}


