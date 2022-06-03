namespace SeleniumTrainingCenter.PageObjects.PageInterfaces
{
    public interface IMailPage
    {
        IMailPage Login(string email, string password);

        IMailPage Logout();
    }
}
