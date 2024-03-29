﻿using Eticaret.Core.Contracts;
using Eticaret.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult Index()
        {
            List<Order> orders = orderService.GetOrderList();

            return View(orders);
        }

        public ActionResult UpdateOrder(string Id)
        {
            ViewBag.StatusList = new List<string>() {
                "Sipariş Oluştutuldu",
                "Ödeme Tamamlandı",
                "Sipariş Gönderildi",
                "Sipariş Tamamlandı"
            };
            Order order = orderService.GetOrder(Id);
            return View(order);
        }

        [HttpPost]
        public ActionResult UpdateOrder(Order updatedOrder, string Id)
        {
            Order order = orderService.GetOrder(Id);

            order.OrderStatus = updatedOrder.OrderStatus;
            orderService.UpdateOrder(order);

            return RedirectToAction("Index");
        }
    }
}