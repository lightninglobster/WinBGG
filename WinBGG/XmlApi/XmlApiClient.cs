namespace WinBGG.XmlApi
{
    public class XmlApiClient : IXmlApiClient
    {
        #region MVs
        protected bool _connected;
        protected bool _valid;
        #endregion MVs

        #region Properties
        public bool IsValid
        {
            get { return _valid; }
        }
        public bool Status
        {
            get { return _connected; }
        }
        #endregion Properties

        #region Constructors
        public XmlApiClient()
        {
            _connected = false;
            _valid = true;
        }
        #endregion Constructors

        #region Public Methods
        public bool Connect()
        {
            return (_connected = true);
        }
        public bool Disconnect()
        {
            return (_connected = false);
        }
        #endregion Public Methods
    }
}
