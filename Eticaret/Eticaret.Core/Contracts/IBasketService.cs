// SPDX-FileCopyrightText: 2026 Bora Yarkın
// SPDX-License-Identifier: GPL-3.0-only

﻿using Eticaret.Core.ViewModels;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Eticaret.Core.Contracts
{
    public interface IBasketService
    {
        void AddToBasket(HttpContext httpContext, string productId);
        void RemoveFromBasket(HttpContext httpContext, string itemId);
        List<BasketItemViewModel> GetBasketItems(HttpContext httpContext);
        BasketSummaryViewModel GetBasketSummary(HttpContext httpContext);
        void ClearBasket(HttpContext httpContext);
    }
}
