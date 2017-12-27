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
    public class FinancialPlan_computation
    {
        ExpenseTypes expenseT = new ExpenseTypes();
        ExpensePlan_resultDAL expDAL = new ExpensePlan_resultDAL();
        ExpensesDAL expenseD=new ExpensesDAL();
        IncomeDAL incomeD=new IncomeDAL();
        IncomeSourceBO incomeB = new IncomeSourceBO();
        ExpensesBO expenseB = new ExpensesBO();
        updateThreshold upTH = new updateThreshold();
        FinancialPlanResult planResult=new FinancialPlanResult();
        decimal[] arrExpense=new decimal[10];
        decimal[] arrexpenseneg=new decimal[10];
        string[] arrexpName=new string[10];
        string[] arrexpName1=new string[10];
        decimal[] result=new decimal[10];
        string prt1="", prt2="";
        decimal houseHoldTH;
        decimal healthTH ;
        decimal educationTH;
        decimal travelTH ;
        decimal lifestyleTH ;
        
        int i = 0,m=0;
        public void getPriority(string prior1, string prior2)
        {
            prt1 = prior1;
            prt2 = prior2;
        }

        
    
        public void setThreshold()
        {
           string  priority1 = prt1;
           prt1 = "";
            string priority2 = prt2;
            prt1 = "";
            switch (priority1)
            {
                case "Household":
                    {

                            houseHoldTH = (decimal)23.00;
                            Priority2(priority2,priority1);
   

                    }
                    break;
                case "Health":
                    {
                        healthTH = (decimal)23.00;
                        Priority2(priority2, priority1);

                    }
                    break;
                case "Education":
                    {
                        educationTH = (decimal)23.00;
                        Priority2(priority2, priority1);

                    }
                    break;
                case "Travel":
                    {
                        travelTH = (decimal)23.00;
                        Priority2(priority2, priority1);

                    }
                    break;
                case "Lifestyle":
                    {
                        lifestyleTH = (decimal)23.00;
                        Priority2(priority2, priority1);

                    }
                    break;
            }
        }
        public void Priority2(string pr2,string pr1)
        {
            switch (pr2)
            {
                case "Household":
                    {

                        houseHoldTH = (decimal)14.00;
                        if (pr1 == "Health" )
                        {
                           
                            educationTH = (decimal)10.00;
                            travelTH = (decimal)10.00;
                            lifestyleTH = (decimal)9.00;
                        }
                        else if (pr1 == "Education")
                        {
                            healthTH = (decimal)10.00;
                            travelTH = (decimal)10.00;
                            lifestyleTH = (decimal)9.00;
                        }
                        else if (pr1 == "Travel")
                        {
                            healthTH = (decimal)10.00;
                            educationTH = (decimal)10.00;
                           lifestyleTH = (decimal)9.00;
                        }
                        else if (pr1 == "Lifestyle")
                        {
                            healthTH = (decimal)10.00;
                            travelTH = (decimal)9.00;
                            educationTH = (decimal)10.00;
                        }
                     


                    }
                    break;
                case "Health":
                    {

                        healthTH = (decimal)14.00;
                        if (pr1 == "Household")
                        {

                            educationTH = (decimal)10.00;
                            travelTH = (decimal)10.00;
                            lifestyleTH = (decimal)9.00;
                        }
                        else if (pr1 == "Education")
                        {
                            houseHoldTH = (decimal)10.00;
                            travelTH = (decimal)10.00;
                            lifestyleTH = (decimal)9.00;
                        }
                        else if (pr1 == "Travel")
                        {
                            houseHoldTH = (decimal)10.00;
                            educationTH = (decimal)10.00;
                           lifestyleTH = (decimal)9.00;
                        }
                        else if (pr1 == "Lifestyle")
                        {
                            houseHoldTH = (decimal)10.00;
                             travelTH = (decimal)9.00;
                             educationTH = (decimal)10.00;
                        }



                    }
                    break;
                case "Education":
                    {

                         educationTH = (decimal)14.00;
                        if (pr1 == "Health")
                        {

                             houseHoldTH = (decimal)10.00;
                             travelTH = (decimal)10.00;
                             lifestyleTH = (decimal)9.00;
                        }
                        else if (pr1 == "Household")
                        {
                             healthTH = (decimal)10.00;
                             travelTH = (decimal)10.00;
                             lifestyleTH = (decimal)9.00;
                        }
                        else if (pr1 == "Travel")
                        {
                             healthTH = (decimal)10.00;
                             houseHoldTH = (decimal)10.00;
                             lifestyleTH = (decimal)9.00;
                        }
                        else if (pr1 == "Lifestyle")
                        {
                             healthTH = (decimal)10.00;
                             travelTH = (decimal)9.00;
                             houseHoldTH = (decimal)10.00;
                        }



                    }
                    break;
                case "Travel":
                    {

                         travelTH = (decimal)14.00;
                        if (pr1 == "Health")
                        {

                             educationTH = (decimal)10.00;
                             houseHoldTH = (decimal)10.00;
                             lifestyleTH = (decimal)9.00;
                        }
                        else if (pr1 == "Education")
                        {
                             healthTH = (decimal)10.00;
                             houseHoldTH = (decimal)10.00;
                             lifestyleTH = (decimal)9.00;
                        }
                        else if (pr1 == "household")
                        {
                             healthTH = (decimal)10.00;
                             educationTH = (decimal)10.00;
                             lifestyleTH = (decimal)9.00;
                        }
                        else if (pr1 == "Lifestyle")
                        {
                             healthTH = (decimal)10.00;
                             houseHoldTH = (decimal)10.00;
                             educationTH = (decimal)9.00;
                        }



                    }
                    break;
                case "Lifestyle":
                    {

                         lifestyleTH = (decimal)14.00;
                        if (pr1 == "Health")
                        {

                             educationTH = (decimal)10.00;
                             travelTH = (decimal)9.00;
                             houseHoldTH = (decimal)10.00;
                        }
                        else if (pr1 == "Education")
                        {
                             healthTH = (decimal)10.00;
                             travelTH = (decimal)9.00;
                             houseHoldTH = (decimal)10.00;
                        }
                        else if (pr1 == "Travel")
                        {
                             healthTH = (decimal)10.00;
                             educationTH = (decimal)10.00;
                             houseHoldTH = (decimal)9.00;
                        }
                        else if (pr1 == "Household")
                        {
                             healthTH = (decimal)10.00;
                             travelTH = (decimal)9.00;
                             educationTH = (decimal)10.00;
                        }



                    }
                    break;
            }
        }
        
        decimal totalIncome,basicSaving=(decimal)34.00,savingRemain;
        public void normatThreshold()
        {
             houseHoldTH = (decimal)23.00;
             healthTH = (decimal)14.00;
             educationTH = (decimal)10.00;
             travelTH = (decimal)10.00;
             lifestyleTH = (decimal)9.00;
        }
        decimal sum=0,temp;


        public ExpenseTypes InsertExpenseManage(ExpensesBO expB,IncomeSourceBO incB)
        {

            if (prt2 == "" && prt1 =="")
            {
                normatThreshold();
            }
            else
            {
                setThreshold();
            }
            try
            {
                totalIncome = incB.bankAccount + incB.jobIncome + incB.rentalIncome + incB.retirementPension + incB.socialSecurity + incB.otherSources;
                if (expB.education == 0) // Distribute education expense threshold over all other expenses threshold
                {
                    decimal houseper = (decimal)((houseHoldTH / 66) * 100);
                    houseHoldTH = houseHoldTH + ((houseper * educationTH) / 100);
                    expenseT.householdTh = houseHoldTH;
                    expenseT.householdActual_value = expB.houseRent + expB.utilities;
                    expenseT.householdActual_percentage = (expenseT.householdActual_value / totalIncome) * 100;
                    expenseT.householdTh_value = (houseHoldTH * totalIncome) / 100;

                    decimal healthper = (decimal)((healthTH / 66) * 100);
                    healthTH = healthTH + ((healthper * educationTH) / 100);
                    expenseT.healthTh = healthTH;
                    expenseT.healthActual_value = expB.health;
                    expenseT.healthActual_percentage = (expB.health / totalIncome) * 100;
                    expenseT.healthTh_value = (healthTH * totalIncome) / 100;

                    decimal travelper = (decimal)((educationTH / 66) * 100);
                    travelTH = travelTH + ((travelper * educationTH) / 100);
                    expenseT.travelTH = travelTH;
                    expenseT.travelActual_value = expB.transport;
                    expenseT.travelActual_percentage = (expB.transport / totalIncome) * 100;
                    expenseT.travelTh_value = (travelTH * totalIncome) / 100;

                    decimal lifestyleper = (decimal)((travelTH / 66) * 100);
                    lifestyleTH = lifestyleTH + ((lifestyleper * educationTH) / 100);
                    expenseT.lifestyleTH = lifestyleTH;
                    expenseT.lifestyleActual_value = expB.emiLoans + expB.entertainment + expB.hotelBill + expB.shopping + expB.otherExp;
                    expenseT.lifestyleActual_percentage = (expenseT.lifestyleActual_value / totalIncome) * 100;
                    expenseT.lifestyleTh_value = (lifestyleTH * totalIncome) / 100;

                    
                    expenseT.educationActual_value = 0;
                    expenseT.educationActual_percentage = 0;
                    expenseT.educationTh_value = 0;
                    expenseT.educationTH = 0;
                    upTH.thresholdUpdateforfour(houseHoldTH, healthTH, travelTH, lifestyleTH);

                }
                else
                {
                    
                    upTH.UpdatepriorityThreshold(houseHoldTH, healthTH, educationTH, travelTH, lifestyleTH);
                    
                    
                    expenseT.householdActual_value = expB.houseRent + expB.utilities;
                    expenseT.householdActual_percentage = (expenseT.householdActual_value / totalIncome) * 100;
                    expenseT.householdTh_value = (houseHoldTH * totalIncome) / 100;
                    expenseT.householdTh = houseHoldTH;

                    expenseT.healthActual_value = expB.health;
                    expenseT.healthActual_percentage = (expB.health / totalIncome) * 100;
                    expenseT.healthTh_value = (healthTH * totalIncome) / 100;
                    expenseT.healthTh = healthTH;

                    expenseT.educationActual_value = expB.education;
                    expenseT.educationActual_percentage = (expB.education / totalIncome) * 100;
                    expenseT.educationTh_value = (educationTH * totalIncome) / 100;
                    expenseT.educationTH = educationTH;

                    expenseT.travelActual_value = expB.transport;
                    expenseT.travelActual_percentage = (expB.transport / totalIncome) * 100;
                    expenseT.travelTh_value = (travelTH * totalIncome) / 100;
                    expenseT.travelTH = travelTH;

                    expenseT.lifestyleActual_value = expB.emiLoans + expB.entertainment + expB.hotelBill + expB.shopping + expB.otherExp;
                    expenseT.lifestyleActual_percentage = (expenseT.lifestyleActual_value / totalIncome) * 100;
                    expenseT.lifestyleTh_value = (lifestyleTH * totalIncome) / 100;
                    expenseT.lifestyleTH = lifestyleTH;
                }
                expDAL.UpdateExpense_PlanDetail(expenseT);
               
            }
            catch (Exception ex)
            {
                ex.GetType();
            }
            return expenseT;
            
        }

      public FinancialPlanResult financialPlanResult()
        {
            expenseB=expenseD.GetExpenseDetail();
            incomeB = incomeD.GetIncomeDetail();
            expenseT = InsertExpenseManage(expenseB, incomeB);
          totalIncome = incomeB.bankAccount + incomeB.jobIncome + incomeB.rentalIncome + incomeB.retirementPension +incomeB.socialSecurity + incomeB.otherSources;
          decimal saving_value = (totalIncome * 10) / 100;
         



            decimal household_diff = expenseT.householdActual_percentage - expenseT.householdTh ;
            if (household_diff > 0)
            {
                arrExpense[i] = household_diff;
                arrexpName[i] = "Household";
                i++;
            }
            else if(household_diff<=0)
            {
                arrexpenseneg[m]=Math.Abs(household_diff);
                arrexpName1[m]="Household";
                m++;
            }
            decimal health_diff = expenseT.healthActual_percentage - expenseT.healthTh ;
            if (health_diff > 0)
            {
                arrExpense[i] = health_diff;
                arrexpName[i] = "Health";
                i++;
            }
           else if(health_diff<=0)
            {
                arrexpenseneg[m]=Math.Abs(health_diff);
                arrexpName1[m]="Health";
                m++;
            }
            decimal education_diff = expenseT.educationActual_percentage - expenseT.educationTH;
            if (education_diff > 0)
            {
                arrExpense[i] = education_diff;
                arrexpName[i] = "Education";
                i++;
            }
           else if(education_diff<=0)
            {
                arrexpenseneg[m]=Math.Abs(education_diff);
                arrexpName1[m]="Education";
                m++;
            }
            decimal travel_diff = expenseT.travelActual_percentage - expenseT.travelTH;
            if (travel_diff > 0)
            {
                arrExpense[i] = travel_diff;
                arrexpName[i] = "Travel";
                i++;
            }
           else if(travel_diff<=0)
            {
                arrexpenseneg[m]=Math.Abs(travel_diff);
                arrexpName1[m]="Travel";
                m++;
            }
            decimal lifestyle_diff = expenseT.lifestyleActual_percentage - expenseT.lifestyleTH;
            if (lifestyle_diff > 0)
            {
                arrExpense[i] = lifestyle_diff;
                arrexpName[i] = "Lifestyle";
                i++;
            }
           else if(lifestyle_diff<=0)
            {
                arrexpenseneg[m]=Math.Abs(lifestyle_diff);
                arrexpName1[m]="Lifestyle";
                m++;
            }
          int size=i;
            Array.Sort(arrExpense,arrexpName);
            Array.Reverse(arrExpense);
            Array.Reverse(arrexpName);
            for (int j = 0; j < size; j++)
            {
                result[i] = arrExpense[i];
            }
                
                    decimal totalExpensePercentage = expenseT.householdActual_percentage + expenseT.healthActual_percentage + expenseT.educationActual_percentage + expenseT.travelActual_percentage + expenseT.lifestyleActual_percentage;
                    decimal savingdiff = basicSaving - (100 - totalExpensePercentage);
                    savingRemain = 66 - totalExpensePercentage;
                    
                        for(int n=0;n<m;n++)                 //adjusting priority expense types percentages 
                            {
                               // temp= arrexpenseneg[n];
                                while(arrexpenseneg[n]!=0)
                                {
                                    for(int l=0;l<size;l++)
                                    {
                                        if (arrExpense[l] >= arrexpenseneg[n])
                                        {
                                            arrExpense[l] = arrExpense[l] - arrexpenseneg[n];
                                            arrexpenseneg[n] = 0;
                                        }
                                        else if (arrExpense[l] < arrexpenseneg[n] && arrExpense[l]!=0)
                                        {
                                            arrexpenseneg[n] = arrexpenseneg[n] - arrExpense[l];
                                            arrExpense[l] = 0;

                                        }
                                    }
                                    if (savingRemain > 0)
                                    {
                                        savingRemain = savingRemain - arrexpenseneg[n];
                                        arrexpenseneg[n] = 0;
                                    }
                                    
                                    
                                }
                            }
                        for(int p=0;p<size;p++)               //Adding remaining percentages of all types of expenses to basic saving percentages
                        {
                            if(arrExpense[p]>0)
                            {
                                basicSaving = basicSaving + arrExpense[p];
                                //arrExpense[p]=0;
                            }
                        }
      //}

                            for (int u = 0; u < size; u++)
                            {
                                string value = arrexpName[u];

                                switch (value)
                                {
                                    case "Household":
                                        {
                                            if(arrExpense[u]>0)
                                            {
                                                planResult.householdPlan_percentage=(decimal)expenseT.householdTh;
                                                planResult.householdPlan_value = (decimal)(totalIncome * planResult.householdPlan_percentage) / 100;
                                                planResult.householdSavingPersentages = (decimal)arrExpense[u];
                                                planResult.householdSavingAmount = (decimal)(totalIncome * planResult.householdSavingPersentages) / 100;
                                            }
                                            else if(arrExpense[u]==0)
                                            {
                                                planResult.householdPlan_percentage = (decimal)expenseT.householdTh;
                                                planResult.householdPlan_value = (decimal)(totalIncome * planResult.householdPlan_percentage) / 100;
                                                planResult.householdSavingPersentages = (decimal)0;
                                                planResult.householdSavingAmount = (decimal)0;
                                            }
                                           
                                        }
                                        break;
                                    case "Health":
                                        {
                                            if(arrExpense[u]>0)
                                            {
                                                planResult.healthPlan_percentage = (decimal)expenseT.healthTh - arrexpenseneg[u];
                                                planResult.healthPlan_value = (decimal)(totalIncome * planResult.healthPlan_percentage) / 100;
                                                planResult.healthSavingPersentages = (decimal)arrExpense[u];
                                                planResult.healthSavingAmount = (decimal)(totalIncome * planResult.healthSavingPersentages) / 100;
                                            }
                                            else if(arrExpense[u]==0)
                                            {
                                                planResult.healthPlan_percentage = (decimal)expenseT.healthTh - arrexpenseneg[u];
                                                planResult.healthPlan_value = (decimal)(totalIncome * planResult.healthPlan_percentage) / 100;
                                                planResult.healthSavingPersentages = (decimal)0;
                                                planResult.healthSavingAmount = (decimal)0;
                                            }
                                            
                                        }
                                        break;
                                    case "Education":
                                        {
                                            if(arrExpense[u]>0)
                                            {
                                                planResult.educationPlan_percentage = (decimal)expenseT.educationTH - arrexpenseneg[u];
                                                planResult.educationPlan_value = (decimal)(totalIncome * planResult.educationPlan_percentage) / 100;
                                                planResult.educationSavingPersentages = (decimal)arrExpense[u];
                                                planResult.educationSavingAmount = (decimal)(totalIncome * planResult.educationSavingPersentages) / 100;
                                            }
                                            else if(arrExpense[u]==0)
                                            {
                                                planResult.educationPlan_percentage = (decimal)expenseT.educationTH - arrexpenseneg[u];
                                                planResult.educationPlan_value = (decimal)(totalIncome * planResult.educationPlan_percentage) / 100;
                                                planResult.educationSavingPersentages = (decimal)0;
                                                planResult.educationSavingAmount = (decimal)0;
                                            }
                                          
                                        }
                                        break;
                                    case "Travel":
                                        {
                                            if(arrExpense[u]>0)
                                            {
                                                planResult.travelPlan_percentage = (decimal)expenseT.travelTH - arrexpenseneg[u];
                                                planResult.travelPlan_value = (decimal)(totalIncome * planResult.travelPlan_percentage) / 100;
                                                planResult.travelSavingPersentages = (decimal)arrExpense[u];
                                                planResult.travelSavingAmount = (decimal)(totalIncome * planResult.travelSavingPersentages) / 100;
                                            }
                                            else if(arrExpense[u]==0)
                                            {
                                                planResult.travelPlan_percentage = (decimal)expenseT.travelTH - arrexpenseneg[u];
                                                planResult.travelPlan_value = (decimal)(totalIncome * planResult.travelPlan_percentage) / 100;
                                                planResult.travelSavingPersentages = (decimal)0;
                                                planResult.travelSavingAmount = (decimal)0;
                                            }
                                           
                                        }
                                        break;
                                    case "Lifestyle":
                                        {
                                            if(arrExpense[u]>0)
                                            {
                                                planResult.lifestylePlan_percentage = (decimal)expenseT.lifestyleTH - arrexpenseneg[u];
                                                planResult.lifestylePlan_value = (decimal)(totalIncome * planResult.lifestylePlan_percentage) / 100;
                                                planResult.lifestyleSavingPersentages = (decimal)arrExpense[u];
                                                planResult.lifestyleSavingAmount = (decimal)(totalIncome * planResult.lifestyleSavingPersentages) / 100;
                                            }
                                             if(arrExpense[u]==0)
                                            {
                                                planResult.lifestylePlan_percentage = (decimal)expenseT.lifestyleTH - arrexpenseneg[u];
                                                planResult.lifestylePlan_value = (decimal)(totalIncome * planResult.lifestylePlan_percentage) / 100;
                                                planResult.lifestyleSavingPersentages = (decimal)0;
                                                planResult.lifestyleSavingAmount = (decimal)0;
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
                                                planResult.householdPlan_percentage = (decimal)expenseT.householdTh;
                                                planResult.householdPlan_value = (decimal)(totalIncome * planResult.householdPlan_percentage) / 100;
                                                planResult.householdSavingPersentages = (decimal)0;
                                                planResult.householdSavingAmount = (decimal)0;
                                            }
                                        }
                                        break;
                                    case "Health":
                                        {
                                            if (arrexpenseneg[u] == 0)
                                            {
                                                planResult.healthPlan_percentage = (decimal)expenseT.healthTh;
                                                planResult.healthPlan_value = (decimal)(totalIncome * planResult.healthPlan_percentage) / 100;
                                                planResult.healthSavingPersentages = (decimal)0;
                                                planResult.healthSavingAmount = (decimal)0;
                                            }
                                        }
                                        break;
                                    case "Education":
                                        {
                                            if (arrexpenseneg[u] == 0)
                                            {
                                                planResult.educationPlan_percentage = (decimal)expenseT.educationTH;
                                                planResult.educationPlan_value = (decimal)(totalIncome * planResult.educationPlan_percentage) / 100;
                                                planResult.educationSavingPersentages = (decimal)0;
                                                planResult.educationSavingAmount = (decimal)0;
                                            }
                                        }
                                        break;
                                    case "Travel":
                                        {
                                            if (arrexpenseneg[u] == 0)
                                            {
                                                planResult.travelPlan_percentage = (decimal)expenseT.travelTH;
                                                planResult.travelPlan_value = (decimal)(totalIncome * planResult.travelPlan_percentage) / 100;
                                                planResult.travelSavingPersentages = (decimal)0;
                                                planResult.travelSavingAmount = (decimal)0;
                                            }
                                        }
                                        break;
                                    case "Lifestyle":
                                        {
                                          if (arrexpenseneg[u] == 0)
                                            {
                                                planResult.lifestylePlan_percentage = (decimal)expenseT.lifestyleTH;
                                                planResult.lifestylePlan_value = (decimal)(totalIncome * planResult.lifestylePlan_percentage) / 100;
                                                planResult.lifestyleSavingPersentages = (decimal)0;
                                                planResult.lifestyleSavingAmount = (decimal)0;
                                            }
                                        }
                                        break;
                                }
                            }
                            expDAL.UpdateExpense_PlanResult(planResult);
                            return planResult;
                        }
      public DataSet BindfinancialData_grid()
      {
          incomeB = incomeD.GetIncomeDetail();
          expenseB = expenseD.GetExpenseDetail();
          expenseT = InsertExpenseManage(expenseB, incomeB);


          DataSet data = expDAL.getFinancialPlanData();
          return data;
      }
      public DataSet BindfinancialPlan_grid()
      {
          planResult = financialPlanResult();
          DataSet dataS = expDAL.getFinancialPlanResult();
          return dataS;
      }
                    }
                

            
        
    
}