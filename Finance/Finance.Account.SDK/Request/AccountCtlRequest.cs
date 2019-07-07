﻿using Finance.Account.SDK.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Account.SDK.Request
{
    public class AccountCtlRequest : IFinanceRequest<SampleItemListResponse>
    {
        public string Method => "/accountctl/list";
    }
}
