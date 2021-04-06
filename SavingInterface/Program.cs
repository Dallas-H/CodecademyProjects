namespace SavingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");

            PasswordManager pm = new PasswordManager("iluvopie", false);

            tdl.Display();
            pm.Display();

            //pm.ChangePassword("iluvopie","pieloveme");
            //pm.Display();

            //tdl.Reset();
            //pm.Reset();

            //tdl.Display();
            //pm.Display();
        }
    }
}
