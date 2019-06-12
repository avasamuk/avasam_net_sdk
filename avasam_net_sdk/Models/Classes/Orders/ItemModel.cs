using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models.Classes
{
    /// OrdersCreationController.cs
    /// <summary>
    /// This class is used to display ItemModel
    /// </summary>
    public class ItemModel
    {
        /// <summary>
        /// used to display Orderid
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// used to display itemid
        /// </summary>
        public string ItemId { get; set; }
        /// <summary>
        /// used to display StockItemId
        /// </summary>
        public string StockItemId { get; set; }
        /// <summary>
        /// used to display ItemNumber
        /// </summary>
        public string ItemNumber { get; set; }
        /// <summary>
        /// used to display SKU
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        /// used to display ItemSource
        /// </summary>
        public object ItemSource { get; set; }
        /// <summary>
        /// used to display Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// used to display PackQty
        /// </summary>
        public int PackQty { get; set; }
        /// <summary>
        /// used to display CategoryName
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// used to display CopmpositeAvailablity
        /// </summary>
        public object CompositeAvailablity { get; set; }
        /// <summary>
        /// used to display RowId
        /// </summary>
        public string RowId { get; set; }
        /// <summary>
        /// used to display StockLevelSpecified
        /// </summary>
        public bool StockLevelsSpecified { get; set; }
        /// <summary>
        /// used to display OnOrder
        /// </summary>
        public int? OnOrder { get; set; }
        /// <summary>
        /// used to display  inorderboook
        /// </summary>
        public int? InOrderBook { get; set; }
        /// <summary>
        /// used to display Level
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// used to display MinimumLevel
        /// </summary>
        public int? MinimumLevel { get; set; }
        /// <summary>
        /// used to display AvailableStock
        /// </summary>
        public int AvailableStock { get; set; }
        /// <summary>
        /// used to display ProcePerUnit
        /// </summary>
        public double PricePerUnit { get; set; }
        /// <summary>
        /// used to display Price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// used to display Discount
        /// </summary>
        public double Discount { get; set; }
        /// <summary>
        /// used to display Tax
        /// </summary>
        public double Tax { get; set; }
        /// <summary>
        /// used to display VAt
        /// </summary>
        public double Vat { get; set; }
        /// <summary>
        /// used to display Cost
        /// </summary>
        public double Cost { get; set; }
        /// <summary>
        /// used to display CostIncTax
        /// </summary>
        public double CostIncTax { get; set; }
        /// <summary>
        /// used to display CompositeSubItems
        /// </summary>
        public List<object> CompositeSubItems { get; set; }
        /// <summary>
        /// used to display IsService
        /// </summary>
        public bool IsService { get; set; }
        /// <summary>
        /// used to display SalesTax
        /// </summary>
        public double SalesTax { get; set; }
        /// <summary>
        /// used to display TaxCostInclusive
        /// </summary>
        public bool TaxCostInclusive { get; set; }
        /// <summary>
        /// used to display PartShipped
        /// </summary>
        public bool PartShipped { get; set; }
        /// <summary>
        /// used to display Weight
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// used to display Barcodenumber
        /// </summary>
        public string BarcodeNumber { get; set; }
        /// <summary>
        /// used to display Market
        /// </summary>
        public int Market { get; set; }
        /// <summary>
        /// used to display ChannelSku
        /// </summary>
        public string ChannelSKU { get; set; }
        /// <summary>
        /// used to display ChannelTitle
        /// </summary>
        public string ChannelTitle { get; set; }
        /// <summary>
        /// used to display HasImage
        /// </summary>
        public bool HasImage { get; set; }
        /// <summary>
        /// used to display ImageiD
        /// </summary>
        public object ImageId { get; set; }
        /// <summary>
        /// used to display list of Additional info
        /// </summary>
        public List<object> AdditionalInfo { get; set; }
        /// <summary>
        /// used to display StockLevelIndicator
        /// </summary>
        public int StockLevelIndicator { get; set; }
        /// <summary>
        /// used to display binrack
        /// </summary>
        public object BinRack { get; set; }
        /// <summary>
        /// used to display returnQuantity
        /// </summary>
        public int ReturnQuantity { get; set; }
        /// <summary>
        /// used to display Amount
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// used to display reason
        /// </summary>
        public string Reason { get; set; }
    }
}
