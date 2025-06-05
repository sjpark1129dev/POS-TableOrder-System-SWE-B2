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
        
        private OrderAndPayRepository _orderAndPayRepository;

        public OrderAndPayController()
        {
            _orderAndPayRepository = new OrderAndPayRepository();
        }

        public bool PayTable(int tableId)
        {
            return _orderAndPayRepository.ProcessPaymentByTable(tableId);
        }

        public List<dynamic> GetUnpaidOrderItemsByTable(int tableId)
        {
            return _orderAndPayRepository.GetUnpaidOrdersForGridByTable(tableId);
        }
    }
}