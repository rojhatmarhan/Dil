﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dil
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Decimal money = (Decimal)123456.789;
            LabelCurrency.Text = string.Format("{0:c}", money);
        }

        protected override void InitializeCulture()
        {
            String language = Request.Form["DropDownListLanguage"];
            if ((language != null) && (language != ""))
            {
                if (language == "auto")
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(HttpContext.Current.Request.UserLanguages[0].Trim());
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(HttpContext.Current.Request.UserLanguages[0].Trim());
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
                }
            }
        }
    }
}