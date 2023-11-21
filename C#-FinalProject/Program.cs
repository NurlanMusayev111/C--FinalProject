
while (true)
{
    GetMenues();

    Operation: string operationStr = Console.ReadLine();
    int operation;
    bool isTrueOperation = int.TryParse(operationStr, out operation);

    if (isTrueOperation)
    {
        switch (operation)
        {
            case 1:
                Console.WriteLine("Login");
                break;
            case 2:
                Console.WriteLine("Register");
                break;
            default:
                Console.WriteLine("Operation not found");
                break;
        }
    }
    else
    {
        Console.WriteLine("Operation format is wrong,please try again");
        goto Operation;
    }
}



















static void GetMenues()
{
    Console.WriteLine("(1) Login - (2) Register");
}