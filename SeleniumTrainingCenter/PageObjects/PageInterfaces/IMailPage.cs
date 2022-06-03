namespace SeleniumTrainingCenter.PageObjects.PageInterfaces
{
    public interface IMailPage : IPage
    {
        IMailPage Login(string email, string password);

        IMailPage Logout();
    }
}
