﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Canvia.Claro.Common;

namespace Canvia.Claro.WebAppLog4Net.Paginas
{
    public partial class Pagina01 : System.Web.UI.Page
    {
        private readonly LoggerManager _loggerManager = new LoggerManager(Constantes.Logger01);
        protected void Page_Load(object sender, EventArgs e)
        {
            _loggerManager.SaveLogger("Se inicializo pagina01.",LoggerLevel.Info);
        }
    }
}