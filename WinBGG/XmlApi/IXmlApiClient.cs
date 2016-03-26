using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBGG.XmlApi
{
    interface IXmlApiClient
    {
        #region Properties
        bool IsValid { get; }
        bool Status { get; }
        #endregion Properties

        #region Public Methods
        bool Connect();
        bool Disconnect();
        #endregion Public Methods
    }
}
