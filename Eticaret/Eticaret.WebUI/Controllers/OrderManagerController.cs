// SPDX-FileCopyrightText: 2026 Bora Yarkın
// SPDX-License-Identifier: GPL-3.0-only

﻿using Eticaret.Core.Contracts;
using Eticaret.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Eticaret.WebUI.Controllers
{
    public class OrderManagerController : Controller
    {
        IOrderService orderService;

        public OrderManagerController(IOrderService OrderService)
        {
            this.orderService = OrderService;
        }
        // GET: OrderManager
        public IActionResult Index()
        {
            List<Order> orders = orderService.GetOrderList();

            return View(orders);
        }

        public IActionResult UpdateOrder(string Id)
        {
            ViewBag.StatusList = new List<string>() {
                "Sipariş Oluştutuldu",
                "Ödeme Tamamlandı",
                "Sipariş Gönderildi",
                "Sipariş Tamamlandı"
            };
            Order order = orderService.GetOrder(Id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateOrder(Order updatedOrder, string Id)
        {
            Order order = orderService.GetOrder(Id);
            if (order == null)
            {
                return NotFound();
            }

            order.OrderStatus = updatedOrder.OrderStatus;
            orderService.UpdateOrder(order);

            return RedirectToAction("Index");
        }
    }
}
