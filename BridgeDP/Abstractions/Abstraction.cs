using BridgeDP.Implementor;

namespace BridgeDP.Abstractions
{
    public abstract class AbstractionWeb
    {
        private IWebPage _webPage;

        protected AbstractionWeb()
        {
            _webPage = new FormPage();
        }

        public virtual void GetColor(string color)
        {
            _webPage.GetColor(color);
        }

    }


}
