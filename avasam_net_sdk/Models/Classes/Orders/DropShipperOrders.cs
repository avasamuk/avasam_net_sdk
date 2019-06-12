
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models.Classes
{
    /// <summary>
    /// This class is used to display for dropshipperorders
    /// </summary>
    public class DropShipperOrders : BaseRequest
    {
        /// <summary>
        ///  unique id for DropShipperOrderhistory collection
        /// </summary>
      
        public string _id { get; set; }
        /// <summary>
        /// Used to display for shipper id
        /// </summary>
        public string ShipperId { get; set; }
        /// <summary>
        /// display unique the order id
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// display unique numorderid for the order
        /// </summary>
        public string NumOrderId { get; set; }
        /// <summary>
        /// indicated that it is processed to linnworks means dispatch or not
        /// </summary>
        public bool Processed { get; set; }
        /// <summary>
        /// dispatch datetime
        /// </summary>
        public object ProcessedDateTime { get; set; }
        /// <summary>
        /// display the location id 
        /// </summary>
        public object FulfilmentLocationId { get; set; }
        /// <summary>
        /// details of the orders general info.
        /// </summary>
        public GeneralInfo GeneralInfo { get; set; }
        /// <summary>
        /// details of the orders Shipping info.
        /// </summary>
        public ShippingInfo ShippingInfo { get; set; }
        /// <summary>
        ///  details of the orders Customer info.
        /// </summary>
        public CustomerInfo CustomerInfo { get; set; }
        /// <summary>
        /// details of the orders Totals info.
        /// </summary>
        public TotalsInfo TotalsInfo { get; set; }
        /// <summary>
        /// details of the orders FolderName
        /// </summary>
        public List<string> FolderName { get; set; }
        /// <summary>
        /// details of the list of the product which is associated to that order
        /// </summary>
        public List<Item> Items { get; set; }
        /// <summary>
        /// details of errors if occurred
        /// </summary>
        public object ImportErrorCode { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public List<ExportTo> ExportTo { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public List<UpdateHistory> UpdateHistory { get; set; }
        /// <summary>
        /// displayed the date of creation of that order
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public object Reference { get; set; }
        /// <summary>
        /// dipslay the customer id for that order
        /// </summary>
        public string CustomerID { get; set; }
        /// <summary>
        /// display the customer name
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// display the customer type like linnworks or non linnwrks
        /// </summary>
        public string CustomerType { get; set; }
        /// <summary>
        /// display the invoice id
        /// </summary>
        public string InvoiceID { get; set; }
        /// <summary>
        /// display the invoice number
        /// </summary>
        public string InvoiceNumber { get; set; }
        /// <summary>
        /// display the order status it is paid or not or partial paid
        /// </summary>
        public string OrderStatus { get; set; }
        /// <summary>
        /// display the linnworks(seeker) order id
        /// </summary>
        public string CustomerOrderId { get; set; }
        /// <summary>
        /// display the linnworks(seeker) num order id
        /// </summary>
        public string CustomerNumOrderId { get; set; }
        /// <summary>
        /// display the shipper orderid
        /// </summary>
        public string ShipperOrderId { get; set; }
        /// <summary>
        /// display the shipper numorder id
        /// </summary>
        public string ShipperNumOrderId { get; set; }
        /// <summary>
        /// indicates that invoice is created or not for that order
        /// </summary>
        public bool IsInvoiced { get; set; }
        /// <summary>
        ///  indicates that order created at linnworks or not
        /// </summary>
        public bool IsCreatedAtDropshipper { get; set; }
        /// <summary>
        /// indicates that is order returns
        /// </summary>
        public bool IsReturnRequest { get; set; }
        /// <summary>
        /// indicates that is order returns as draft
        /// </summary>
        public bool IsReturnRequestDraft { get; set; }
        /// <summary>
        /// indicates that is process order means dispthed or not
        /// </summary>
        public bool IsProcessAtSeeker { get; set; }
        /// <summary>
        /// Used to display for stage id
        /// </summary>
        public int StageId { get; set; }
        /// <summary>
        ///  display the surchage for that customer
        /// </summary>
        public double Surcharge { get; set; }
        /// <summary>
        /// indicates that credit notes is created or not for that order.
        /// </summary>
        public bool IsCreditNotes { get; set; }
        /// <summary>
        /// return order status accepted, rejected or sent for return request
        /// </summary>
        public string ReturnStatus { get; set; }
        /// <summary>
        /// Used to display list of payment information
        /// </summary>
        public List<PaymentInformation> PaymentInformation { get; set; }
        /// <summary>
        /// Used to display PO number 
        /// </summary>
        public string PONumber { get; set; }
        /// <summary>
        /// Used to display notes
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// Used to display channel name
        /// </summary>
        public string ChannelName { get; set; }
        /// <summary>
        /// Used to display accountname
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// Used to display field name
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Used to display isdeleted or not
        /// </summary>
        public bool IsDeleted { get; set; }
    }
    /// <summary>
    /// This class is used to display for payment information
    /// </summary>
    public class PaymentInformation
    {
        /// <summary>
        /// Used to display On date time
        /// </summary>
        public DateTime On { get; set; }
        /// <summary>
        /// Used to display method 
        /// </summary>
        public string Method { get; set; }
        /// <summary>
        /// Used to display amount
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// Used to display reference
        /// </summary>
        public string Refrence { get; set; }
    }
    /// <summary>
    /// This class is used to display for General information
    /// </summary>
    public class GeneralInfo
    {
        /// <summary>
        /// display the status
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        ///  not use
        /// </summary>
        public bool LabelPrinted { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public string LabelError { get; set; }
        /// <summary>
        /// indicates invoice printed or not
        /// </summary>
        public bool InvoicePrinted { get; set; }
        /// <summary>
        /// indicates pick list printed or not
        /// </summary>
        public bool PickListPrinted { get; set; }
        /// <summary>
        /// display notes
        /// </summary>
        public int Notes { get; set; }
        /// <summary>
        ///  not use
        /// </summary>
        public bool PartShipped { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public int Marker { get; set; }
        /// <summary>
        ///  display the reference num of that order
        /// </summary>
        public string ReferenceNum { get; set; }
        /// <summary>
        /// display the external reference num of that order
        /// </summary>
        public string ExternalReferenceNum { get; set; }
        /// <summary>
        /// display the date of the order received
        /// </summary>
        public DateTime ReceivedDate { get; set; }
        /// <summary>
        /// dispaly the source name
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// display the subsource name
        /// </summary>
        public string SubSource { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public bool HoldOrCancel { get; set; }
        /// <summary>
        /// display the despatch date of order
        /// </summary>
        public DateTime? DespatchByDate { get; set; }
        /// <summary>
        /// display the count of the items which is in order
        /// </summary>
        public int NumItems { get; set; } 
    }

    /// <summary>
    /// This class is used to display for shipping information
    /// </summary>
    public class ShippingInfo
    {
        /// <summary>
        /// display the vendor 
        /// </summary>
        public string Vendor { get; set; }
        /// <summary>
        ///  display the postal service id
        /// </summary>
        public string PostalServiceId { get; set; }
        /// <summary>
        /// display the postal service name
        /// </summary>
        public string PostalServiceName { get; set; }
        /// <summary>
        ///  not use
        /// </summary>
        public double TotalWeight { get; set; }
        /// <summary>
        ///  not use
        /// </summary>
        public double ItemWeight { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public string PackageCategoryId { get; set; }
        /// <summary>
        ///  not use
        /// </summary>
        public string PackageCategory { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public string PackageTypeId { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public string PackageType { get; set; }
        /// <summary>
        /// display the postage cost including tax
        /// </summary>
        public double PostageCost { get; set; }
        /// <summary>
        /// display the postage cost excluding tax
        /// </summary>
        public double PostageCostExTax { get; set; }
        /// <summary>
        /// display the trancking number
        /// </summary>
        public string TrackingNumber { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public bool ManualAdjust { get; set; } 
    }
    /// <summary>
    /// THis class is used for address
    /// </summary>
    public class Address
    {
        /// <summary>
        /// display the email address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// display the address
        /// </summary>
        public string Address1 { get; set; }
        /// <summary>
        /// display the address
        /// </summary>
        public string Address2 { get; set; }
        /// <summary>
        /// display the address
        /// </summary>
        public string Address3 { get; set; }
        /// <summary>
        /// display the town
        /// </summary>
        public string Town { get; set; }
        /// <summary>
        ///  display the region
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        ///  display the postcode
        /// </summary>
        public string PostCode { get; set; }
        /// <summary>
        /// display the country name
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// display the full name
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// display the company name 
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// display the phone mumber
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        ///  display the country id
        /// </summary>
        public string CountryId { get; set; } 
    }

    /// <summary>
    /// This class ia used to display for customer information
    /// </summary>
    public class CustomerInfo
    {
        /// <summary>
        /// not use
        /// </summary>
        public string ChannelBuyerName { get; set; }
        /// <summary>
        /// display the address details of the drop
        /// </summary>
        public Address Address { get; set; }
        /// <summary>
        /// display the billing address details of shipper
        /// </summary>
        public Address BillingAddress { get; set; } 
    }
    /// <summary>
    /// Thus class is used to display for Total information
    /// </summary>
    public class TotalsInfo
    {
        /// <summary>
        /// display the subtotal of the all the products includes in that order without the tax ann discount
        /// </summary>
        public double Subtotal { get; set; }
        /// <summary>
        /// display the postage cost for that order
        /// </summary>
        public double PostageCost { get; set; }
        /// <summary>
        ///  display the tax
        /// </summary>
        public double Tax { get; set; }
        /// <summary>
        /// display the total of charge of all the products includes in that order with tax and discount.
        /// </summary>
        public double TotalCharge { get; set; }
        /// <summary>
        /// display the payment method for that order
        /// </summary>
        public string PaymentMethod { get; set; }
        /// <summary>
        ///  display the payment method id that order
        /// </summary>
        public string PaymentMethodId { get; set; }
        /// <summary>
        ///  not use
        /// </summary>
        public double ProfitMargin { get; set; }
        /// <summary>
        ///  display the discount for that order
        /// </summary>
        public double TotalDiscount { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public double CountryTaxRate { get; set; } 
    }
    /// <summary>
    /// This class is used to display for Item
    /// </summary>
    public class Item
    {
        /// <summary>
        /// display the order id for this product item
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        ///  display the item id
        /// </summary>
        public string ItemId { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public string StockItemId { get; set; }
        /// <summary>
        /// display the iten number
        /// </summary>
        public string ItemNumber { get; set; }
        /// <summary>
        ///  display the sku for that product item
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public object ItemSource { get; set; }
        /// <summary>
        /// display the title for that product item
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        ///  display the quantity of that product
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// display the category name for that product
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public object CompositeAvailablity { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public string RowId { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public bool StockLevelsSpecified { get; set; }
        /// <summary>
        ///  not use
        /// </summary>
        public int? OnOrder { get; set; }
        /// <summary>
        ///  not use
        /// </summary>
        public int? InOrderBook { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// display the minimum level for the product
        /// </summary>
        public int? MinimumLevel { get; set; }
        /// <summary>
        ///  display the quantity of the product
        /// </summary>
        public int AvailableStock { get; set; }
        /// <summary>
        /// display the price of the product for the one product inc tax and discount
        /// </summary>
        public double PricePerUnit { get; set; }
        /// <summary>
        /// display the price of the product for one product exc tax and discount
        /// </summary>
        public double UnitCost { get; set; }
        /// <summary>
        /// display the dicount of that product
        /// </summary>
        public double Discount { get; set; }
        /// <summary>
        /// display the tax in pound calculated per quantity
        /// </summary>
        public double Tax { get; set; }
        /// <summary>
        /// display the tax in perntange
        /// </summary>
        public double TaxRate { get; set; }
        /// <summary>
        ///  display the price of the product for one product exc tax
        /// </summary>
        public double Cost { get; set; }
        /// <summary>
        ///  display the price of the product for one product inc tax
        /// </summary>
        public double CostIncTax { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public List<Item> CompositeSubItems { get; set; }
        /// <summary>
        ///  not use
        /// </summary>
        public bool IsService { get; set; }
        /// <summary>
        ///  not use
        /// </summary>
        public double SalesTax { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public bool TaxCostInclusive { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public bool PartShipped { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// display the barcode of the product
        /// </summary>
        public string BarcodeNumber { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public int Market { get; set; }
        /// <summary>
        /// display the channel sku
        /// </summary>
        public string ChannelSKU { get; set; }
        /// <summary>
        ///  display the channel title
        /// </summary>
        public string ChannelTitle { get; set; }
        /// <summary>
        /// indicaties this product has image or not
        /// </summary>
        public bool HasImage { get; set; }
        /// <summary>
        /// display the image id 
        /// </summary>
        public object ImageId { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public List<OrderItemOption> AdditionalInfo { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public int StockLevelIndicator { get; set; }
        /// <summary>
        /// not use
        /// </summary>
        public object BinRack { get; set; }
        /// <summary>
        /// if this product is return that how much quantity.
        /// </summary>
        public int ReturnQuantity { get; set; }
        /// <summary>
        /// if this product is return that what amout should be.
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// if this product is return than ehat is the reason.
        /// </summary>
        public string Reason { get; set; }
    }
    /// <summary>
    /// This class is used for Order Item option
    /// </summary>
    public class OrderItemOption
    {
        /// <summary>
        /// Option ID 
        /// </summary>
		public Guid pkOptionId;

        /// <summary>
        /// Option property 
        /// </summary>
		public String Property;

        /// <summary>
        /// Value of the option 
        /// </summary>
		public String Value;
    }
    /// <summary>
    /// This class is used for Update history
    /// </summary>
    public class UpdateHistory
    {
        /// <summary>
        /// display the details of the customer for the order
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// display the remark for that.
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// display the invoice no
        /// </summary>
        public object InvoiceNo { get; set; }
        /// <summary>
        /// dispaly the date when it is cretaed.
        /// </summary>
        public DateTime UpdatedDate { get; set; }
        /// <summary>
        /// display the ip sdress
        /// </summary>
        public string IPAddress { get; set; } 
    }

    /// <summary>
    /// This class is used for Export to
    /// </summary>
    public class ExportTo
    {
        /// <summary>
        /// Used to display id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Used to display steps
        /// </summary>
        public int Steps { get; set; }
    }

}
