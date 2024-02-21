using TamplateMethodDP.Factory;

namespace TamplateMethodDP
{
    public class Clint
    {
        private readonly ReportUserActive _reportUser;

        public Clint(ReportUserActive reportUser)
        {
            _reportUser = reportUser;
        }

        public void RunUserReport()
        {
            _reportUser.TemplateMethod();
        }

    }

}
