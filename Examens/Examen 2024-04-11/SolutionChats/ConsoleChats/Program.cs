using CL_Chat;

internal class Program
{
    private static void Main(string[] args)
    {
        Chat monChat = new Chat(1,"Defaute",1,Race.EUROPEEN);
        PersistanceChatSqlServer persistance = new PersistanceChatSqlServer();

        monChat.Sauvegarder(persistance);
    }
}