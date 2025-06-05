using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POS.Domain;
using POS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Controller
{
    internal class OrderAndPayController
    {
        
        private OrderAndPaymentRepository orderAndPaymentRepository;

        public OrderAndPayController()
        {
            orderAndPaymentRepository = new OrderAndPaymentRepository();
        }

        public bool PayTable(int tableId)
        {
            return orderAndPaymentRepository.ProcessPaymentByTable(tableId);
        }

        public List<dynamic> GetUnpaidOrderItemsByTable(int tableId)
        {
            return orderAndPaymentRepository.GetUnpaidOrdersForGridByTable(tableId);
        }
    }
}