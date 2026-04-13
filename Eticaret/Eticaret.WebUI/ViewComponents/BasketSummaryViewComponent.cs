// SPDX-FileCopyrightText: 2026 Bora Yarkın
// SPDX-License-Identifier: GPL-3.0-only

using Eticaret.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.WebUI.ViewComponents
{
    public class BasketSummaryViewComponent : ViewComponent
    {
        private readonly IBasketService basketService;

        public BasketSummaryViewComponent(IBasketService basketService)
        {
            this.basketService = basketService;
        }

        public IViewComponentResult Invoke()
        {
            var basketSummary = basketService.GetBasketSummary(HttpContext);
            return View("~/Views/Basket/BasketSummary.cshtml", basketSummary);
        }
    }
}
