using System.IO;
using System.Windows;
using Syn.Bot;

namespace bankingAdvisorBot
{
    public partial class ChatBotWindow
    {
        public SynBot Chatbot;
        public ChatBotWindow()
        {
            InitializeComponent();
            Chatbot = new SynBot();
            Chatbot.PackageManager.LoadFromString(File.ReadAllText("Knowledge.simlpk"));
        }

        private void AskQuestion_OnClick(object sender, RoutedEventArgs e)
        {
            var result = Chatbot.Chat(InputBox.Text);
            AnswerBox.Text = string.Format("User: {0}\nBot: {1}\n{2}", InputBox.Text, result.BotMessage, OutputBox.Text);
            QueryBox.Text = string.Empty;
        }
    }
}
