﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class StockPurchaseDetail
    {
        public string ID { get; set; } // Primary Key

        [MaxLength(36)]
        [Required]
        public string StockPurchaseId { get; set; }
        [MaxLength(36)]
        [Required]
        public string CategoryId { get; set; }
        [MaxLength(36)]
        [Required]
        public string ProductId { get; set; }
        [Required]
        public decimal Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUserId { get; set; }
        public virtual StockPurchase StockPurchase { get; set; }
        public virtual Category Category { get; set; } // Navigation property
        public virtual Product Product { get; set; } // Navigation property
    }
}