namespace SingletoneDP
{
    public class WebSiteLink
    {
        private static readonly WebSiteLink _link = new WebSiteLink();

        public static WebSiteLink GetWebSiteLink()
        {
            return _link;
        } 

        private WebSiteLink()
        {

        }


    }

}
