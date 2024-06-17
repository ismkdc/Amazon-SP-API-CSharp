/*
 * Selling Partner API for Finances
 *
 * The Selling Partner API for Finances helps you obtain financial information relevant to a seller's business. You can obtain financial events for a given order, financial event group, or date range without having to wait until a statement period closes. You can also obtain financial event groups for a given date range.
 *
 * OpenAPI spec version: v0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Finances
{
    /// <summary>
    ///     Contains all information related to a financial event.
    /// </summary>
    [DataContract]
    public class FinancialEvents : IEquatable<FinancialEvents>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FinancialEvents" /> class.
        /// </summary>
        /// <param name="ShipmentEventList">A list of shipment events..</param>
        /// <param name="RefundEventList">A list of refund events..</param>
        /// <param name="GuaranteeClaimEventList">A list of guarantee claim events..</param>
        /// <param name="ChargebackEventList">A list of chargeback events..</param>
        /// <param name="PayWithAmazonEventList">PayWithAmazonEventList.</param>
        /// <param name="ServiceProviderCreditEventList">ServiceProviderCreditEventList.</param>
        /// <param name="RetrochargeEventList">RetrochargeEventList.</param>
        /// <param name="RentalTransactionEventList">RentalTransactionEventList.</param>
        /// <param name="ProductAdsPaymentEventList">ProductAdsPaymentEventList.</param>
        /// <param name="ServiceFeeEventList">ServiceFeeEventList.</param>
        /// <param name="SellerDealPaymentEventList">SellerDealPaymentEventList.</param>
        /// <param name="DebtRecoveryEventList">DebtRecoveryEventList.</param>
        /// <param name="LoanServicingEventList">LoanServicingEventList.</param>
        /// <param name="AdjustmentEventList">AdjustmentEventList.</param>
        /// <param name="SAFETReimbursementEventList">SAFETReimbursementEventList.</param>
        /// <param name="SellerReviewEnrollmentPaymentEventList">SellerReviewEnrollmentPaymentEventList.</param>
        /// <param name="FBALiquidationEventList">FBALiquidationEventList.</param>
        /// <param name="CouponPaymentEventList">CouponPaymentEventList.</param>
        /// <param name="ImagingServicesFeeEventList">ImagingServicesFeeEventList.</param>
        /// <param name="NetworkComminglingTransactionEventList">NetworkComminglingTransactionEventList.</param>
        /// <param name="AffordabilityExpenseEventList">AffordabilityExpenseEventList.</param>
        /// <param name="AffordabilityExpenseReversalEventList">AffordabilityExpenseReversalEventList.</param>
        public FinancialEvents()
        {
        }

        public FinancialEvents(ShipmentEventList ShipmentEventList = default,
            ShipmentEventList RefundEventList = default, ShipmentEventList GuaranteeClaimEventList = default,
            ShipmentEventList ChargebackEventList = default, PayWithAmazonEventList PayWithAmazonEventList = default,
            SolutionProviderCreditEventList ServiceProviderCreditEventList = default,
            RetrochargeEventList RetrochargeEventList = default,
            RentalTransactionEventList RentalTransactionEventList = default,
            ProductAdsPaymentEventList ProductAdsPaymentEventList = default,
            ServiceFeeEventList ServiceFeeEventList = default,
            SellerDealPaymentEventList SellerDealPaymentEventList = default,
            DebtRecoveryEventList DebtRecoveryEventList = default,
            LoanServicingEventList LoanServicingEventList = default, AdjustmentEventList AdjustmentEventList = default,
            SAFETReimbursementEventList SAFETReimbursementEventList = default,
            SellerReviewEnrollmentPaymentEventList SellerReviewEnrollmentPaymentEventList = default,
            FBALiquidationEventList FBALiquidationEventList = default,
            CouponPaymentEventList CouponPaymentEventList = default,
            ImagingServicesFeeEventList ImagingServicesFeeEventList = default,
            NetworkComminglingTransactionEventList NetworkComminglingTransactionEventList = default,
            AffordabilityExpenseEventList AffordabilityExpenseEventList = default,
            AffordabilityExpenseEventList AffordabilityExpenseReversalEventList = default)
        {
            this.ShipmentEventList = ShipmentEventList;
            this.RefundEventList = RefundEventList;
            this.GuaranteeClaimEventList = GuaranteeClaimEventList;
            this.ChargebackEventList = ChargebackEventList;
            this.PayWithAmazonEventList = PayWithAmazonEventList;
            this.ServiceProviderCreditEventList = ServiceProviderCreditEventList;
            this.RetrochargeEventList = RetrochargeEventList;
            this.RentalTransactionEventList = RentalTransactionEventList;
            this.ProductAdsPaymentEventList = ProductAdsPaymentEventList;
            this.ServiceFeeEventList = ServiceFeeEventList;
            this.SellerDealPaymentEventList = SellerDealPaymentEventList;
            this.DebtRecoveryEventList = DebtRecoveryEventList;
            this.LoanServicingEventList = LoanServicingEventList;
            this.AdjustmentEventList = AdjustmentEventList;
            this.SAFETReimbursementEventList = SAFETReimbursementEventList;
            this.SellerReviewEnrollmentPaymentEventList = SellerReviewEnrollmentPaymentEventList;
            this.FBALiquidationEventList = FBALiquidationEventList;
            this.CouponPaymentEventList = CouponPaymentEventList;
            this.ImagingServicesFeeEventList = ImagingServicesFeeEventList;
            this.NetworkComminglingTransactionEventList = NetworkComminglingTransactionEventList;
            this.AffordabilityExpenseEventList = AffordabilityExpenseEventList;
            this.AffordabilityExpenseReversalEventList = AffordabilityExpenseReversalEventList;
        }

        /// <summary>
        ///     A list of shipment events.
        /// </summary>
        /// <value>A list of shipment events.</value>
        [DataMember(Name = "ShipmentEventList", EmitDefaultValue = false)]
        public ShipmentEventList ShipmentEventList { get; set; }

        /// <summary>
        ///     A list of refund events.
        /// </summary>
        /// <value>A list of refund events.</value>
        [DataMember(Name = "RefundEventList", EmitDefaultValue = false)]
        public ShipmentEventList RefundEventList { get; set; }

        /// <summary>
        ///     A list of guarantee claim events.
        /// </summary>
        /// <value>A list of guarantee claim events.</value>
        [DataMember(Name = "GuaranteeClaimEventList", EmitDefaultValue = false)]
        public ShipmentEventList GuaranteeClaimEventList { get; set; }

        /// <summary>
        ///     A list of chargeback events.
        /// </summary>
        /// <value>A list of chargeback events.</value>
        [DataMember(Name = "ChargebackEventList", EmitDefaultValue = false)]
        public ShipmentEventList ChargebackEventList { get; set; }

        /// <summary>
        ///     Gets or Sets PayWithAmazonEventList
        /// </summary>
        [DataMember(Name = "PayWithAmazonEventList", EmitDefaultValue = false)]
        public PayWithAmazonEventList PayWithAmazonEventList { get; set; }

        /// <summary>
        ///     Gets or Sets ServiceProviderCreditEventList
        /// </summary>
        [DataMember(Name = "ServiceProviderCreditEventList", EmitDefaultValue = false)]
        public SolutionProviderCreditEventList ServiceProviderCreditEventList { get; set; }

        /// <summary>
        ///     Gets or Sets RetrochargeEventList
        /// </summary>
        [DataMember(Name = "RetrochargeEventList", EmitDefaultValue = false)]
        public RetrochargeEventList RetrochargeEventList { get; set; }

        /// <summary>
        ///     Gets or Sets RentalTransactionEventList
        /// </summary>
        [DataMember(Name = "RentalTransactionEventList", EmitDefaultValue = false)]
        public RentalTransactionEventList RentalTransactionEventList { get; set; }

        /// <summary>
        ///     Gets or Sets ProductAdsPaymentEventList
        /// </summary>
        [DataMember(Name = "ProductAdsPaymentEventList", EmitDefaultValue = false)]
        public ProductAdsPaymentEventList ProductAdsPaymentEventList { get; set; }

        /// <summary>
        ///     Gets or Sets ServiceFeeEventList
        /// </summary>
        [DataMember(Name = "ServiceFeeEventList", EmitDefaultValue = false)]
        public ServiceFeeEventList ServiceFeeEventList { get; set; }

        /// <summary>
        ///     Gets or Sets SellerDealPaymentEventList
        /// </summary>
        [DataMember(Name = "SellerDealPaymentEventList", EmitDefaultValue = false)]
        public SellerDealPaymentEventList SellerDealPaymentEventList { get; set; }

        /// <summary>
        ///     Gets or Sets DebtRecoveryEventList
        /// </summary>
        [DataMember(Name = "DebtRecoveryEventList", EmitDefaultValue = false)]
        public DebtRecoveryEventList DebtRecoveryEventList { get; set; }

        /// <summary>
        ///     Gets or Sets LoanServicingEventList
        /// </summary>
        [DataMember(Name = "LoanServicingEventList", EmitDefaultValue = false)]
        public LoanServicingEventList LoanServicingEventList { get; set; }

        /// <summary>
        ///     Gets or Sets AdjustmentEventList
        /// </summary>
        [DataMember(Name = "AdjustmentEventList", EmitDefaultValue = false)]
        public AdjustmentEventList AdjustmentEventList { get; set; }

        /// <summary>
        ///     Gets or Sets SAFETReimbursementEventList
        /// </summary>
        [DataMember(Name = "SAFETReimbursementEventList", EmitDefaultValue = false)]
        public SAFETReimbursementEventList SAFETReimbursementEventList { get; set; }

        /// <summary>
        ///     Gets or Sets SellerReviewEnrollmentPaymentEventList
        /// </summary>
        [DataMember(Name = "SellerReviewEnrollmentPaymentEventList", EmitDefaultValue = false)]
        public SellerReviewEnrollmentPaymentEventList SellerReviewEnrollmentPaymentEventList { get; set; }

        /// <summary>
        ///     Gets or Sets FBALiquidationEventList
        /// </summary>
        [DataMember(Name = "FBALiquidationEventList", EmitDefaultValue = false)]
        public FBALiquidationEventList FBALiquidationEventList { get; set; }

        /// <summary>
        ///     Gets or Sets CouponPaymentEventList
        /// </summary>
        [DataMember(Name = "CouponPaymentEventList", EmitDefaultValue = false)]
        public CouponPaymentEventList CouponPaymentEventList { get; set; }

        /// <summary>
        ///     Gets or Sets ImagingServicesFeeEventList
        /// </summary>
        [DataMember(Name = "ImagingServicesFeeEventList", EmitDefaultValue = false)]
        public ImagingServicesFeeEventList ImagingServicesFeeEventList { get; set; }

        /// <summary>
        ///     Gets or Sets NetworkComminglingTransactionEventList
        /// </summary>
        [DataMember(Name = "NetworkComminglingTransactionEventList", EmitDefaultValue = false)]
        public NetworkComminglingTransactionEventList NetworkComminglingTransactionEventList { get; set; }

        /// <summary>
        ///     Gets or Sets AffordabilityExpenseEventList
        /// </summary>
        [DataMember(Name = "AffordabilityExpenseEventList", EmitDefaultValue = false)]
        public AffordabilityExpenseEventList AffordabilityExpenseEventList { get; set; }

        /// <summary>
        ///     Gets or Sets AffordabilityExpenseReversalEventList
        /// </summary>
        [DataMember(Name = "AffordabilityExpenseReversalEventList", EmitDefaultValue = false)]
        public AffordabilityExpenseEventList AffordabilityExpenseReversalEventList { get; set; }

        /// <summary>
        ///     Returns true if FinancialEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of FinancialEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinancialEvents input)
        {
            if (input == null)
                return false;

            return
                (
                    ShipmentEventList == input.ShipmentEventList ||
                    (ShipmentEventList != null &&
                     ShipmentEventList.Equals(input.ShipmentEventList))
                ) &&
                (
                    RefundEventList == input.RefundEventList ||
                    (RefundEventList != null &&
                     RefundEventList.Equals(input.RefundEventList))
                ) &&
                (
                    GuaranteeClaimEventList == input.GuaranteeClaimEventList ||
                    (GuaranteeClaimEventList != null &&
                     GuaranteeClaimEventList.Equals(input.GuaranteeClaimEventList))
                ) &&
                (
                    ChargebackEventList == input.ChargebackEventList ||
                    (ChargebackEventList != null &&
                     ChargebackEventList.Equals(input.ChargebackEventList))
                ) &&
                (
                    PayWithAmazonEventList == input.PayWithAmazonEventList ||
                    (PayWithAmazonEventList != null &&
                     PayWithAmazonEventList.Equals(input.PayWithAmazonEventList))
                ) &&
                (
                    ServiceProviderCreditEventList == input.ServiceProviderCreditEventList ||
                    (ServiceProviderCreditEventList != null &&
                     ServiceProviderCreditEventList.Equals(input.ServiceProviderCreditEventList))
                ) &&
                (
                    RetrochargeEventList == input.RetrochargeEventList ||
                    (RetrochargeEventList != null &&
                     RetrochargeEventList.Equals(input.RetrochargeEventList))
                ) &&
                (
                    RentalTransactionEventList == input.RentalTransactionEventList ||
                    (RentalTransactionEventList != null &&
                     RentalTransactionEventList.Equals(input.RentalTransactionEventList))
                ) &&
                (
                    ProductAdsPaymentEventList == input.ProductAdsPaymentEventList ||
                    (ProductAdsPaymentEventList != null &&
                     ProductAdsPaymentEventList.Equals(input.ProductAdsPaymentEventList))
                ) &&
                (
                    ServiceFeeEventList == input.ServiceFeeEventList ||
                    (ServiceFeeEventList != null &&
                     ServiceFeeEventList.Equals(input.ServiceFeeEventList))
                ) &&
                (
                    SellerDealPaymentEventList == input.SellerDealPaymentEventList ||
                    (SellerDealPaymentEventList != null &&
                     SellerDealPaymentEventList.Equals(input.SellerDealPaymentEventList))
                ) &&
                (
                    DebtRecoveryEventList == input.DebtRecoveryEventList ||
                    (DebtRecoveryEventList != null &&
                     DebtRecoveryEventList.Equals(input.DebtRecoveryEventList))
                ) &&
                (
                    LoanServicingEventList == input.LoanServicingEventList ||
                    (LoanServicingEventList != null &&
                     LoanServicingEventList.Equals(input.LoanServicingEventList))
                ) &&
                (
                    AdjustmentEventList == input.AdjustmentEventList ||
                    (AdjustmentEventList != null &&
                     AdjustmentEventList.Equals(input.AdjustmentEventList))
                ) &&
                (
                    SAFETReimbursementEventList == input.SAFETReimbursementEventList ||
                    (SAFETReimbursementEventList != null &&
                     SAFETReimbursementEventList.Equals(input.SAFETReimbursementEventList))
                ) &&
                (
                    SellerReviewEnrollmentPaymentEventList == input.SellerReviewEnrollmentPaymentEventList ||
                    (SellerReviewEnrollmentPaymentEventList != null &&
                     SellerReviewEnrollmentPaymentEventList.Equals(input.SellerReviewEnrollmentPaymentEventList))
                ) &&
                (
                    FBALiquidationEventList == input.FBALiquidationEventList ||
                    (FBALiquidationEventList != null &&
                     FBALiquidationEventList.Equals(input.FBALiquidationEventList))
                ) &&
                (
                    CouponPaymentEventList == input.CouponPaymentEventList ||
                    (CouponPaymentEventList != null &&
                     CouponPaymentEventList.Equals(input.CouponPaymentEventList))
                ) &&
                (
                    ImagingServicesFeeEventList == input.ImagingServicesFeeEventList ||
                    (ImagingServicesFeeEventList != null &&
                     ImagingServicesFeeEventList.Equals(input.ImagingServicesFeeEventList))
                ) &&
                (
                    NetworkComminglingTransactionEventList == input.NetworkComminglingTransactionEventList ||
                    (NetworkComminglingTransactionEventList != null &&
                     NetworkComminglingTransactionEventList.Equals(input.NetworkComminglingTransactionEventList))
                ) &&
                (
                    AffordabilityExpenseEventList == input.AffordabilityExpenseEventList ||
                    (AffordabilityExpenseEventList != null &&
                     AffordabilityExpenseEventList.Equals(input.AffordabilityExpenseEventList))
                ) &&
                (
                    AffordabilityExpenseReversalEventList == input.AffordabilityExpenseReversalEventList ||
                    (AffordabilityExpenseReversalEventList != null &&
                     AffordabilityExpenseReversalEventList.Equals(input.AffordabilityExpenseReversalEventList))
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinancialEvents {\n");
            sb.Append("  ShipmentEventList: ").Append(ShipmentEventList).Append("\n");
            sb.Append("  RefundEventList: ").Append(RefundEventList).Append("\n");
            sb.Append("  GuaranteeClaimEventList: ").Append(GuaranteeClaimEventList).Append("\n");
            sb.Append("  ChargebackEventList: ").Append(ChargebackEventList).Append("\n");
            sb.Append("  PayWithAmazonEventList: ").Append(PayWithAmazonEventList).Append("\n");
            sb.Append("  ServiceProviderCreditEventList: ").Append(ServiceProviderCreditEventList).Append("\n");
            sb.Append("  RetrochargeEventList: ").Append(RetrochargeEventList).Append("\n");
            sb.Append("  RentalTransactionEventList: ").Append(RentalTransactionEventList).Append("\n");
            sb.Append("  ProductAdsPaymentEventList: ").Append(ProductAdsPaymentEventList).Append("\n");
            sb.Append("  ServiceFeeEventList: ").Append(ServiceFeeEventList).Append("\n");
            sb.Append("  SellerDealPaymentEventList: ").Append(SellerDealPaymentEventList).Append("\n");
            sb.Append("  DebtRecoveryEventList: ").Append(DebtRecoveryEventList).Append("\n");
            sb.Append("  LoanServicingEventList: ").Append(LoanServicingEventList).Append("\n");
            sb.Append("  AdjustmentEventList: ").Append(AdjustmentEventList).Append("\n");
            sb.Append("  SAFETReimbursementEventList: ").Append(SAFETReimbursementEventList).Append("\n");
            sb.Append("  SellerReviewEnrollmentPaymentEventList: ").Append(SellerReviewEnrollmentPaymentEventList)
                .Append("\n");
            sb.Append("  FBALiquidationEventList: ").Append(FBALiquidationEventList).Append("\n");
            sb.Append("  CouponPaymentEventList: ").Append(CouponPaymentEventList).Append("\n");
            sb.Append("  ImagingServicesFeeEventList: ").Append(ImagingServicesFeeEventList).Append("\n");
            sb.Append("  NetworkComminglingTransactionEventList: ").Append(NetworkComminglingTransactionEventList)
                .Append("\n");
            sb.Append("  AffordabilityExpenseEventList: ").Append(AffordabilityExpenseEventList).Append("\n");
            sb.Append("  AffordabilityExpenseReversalEventList: ").Append(AffordabilityExpenseReversalEventList)
                .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as FinancialEvents);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (ShipmentEventList != null)
                    hashCode = hashCode * 59 + ShipmentEventList.GetHashCode();
                if (RefundEventList != null)
                    hashCode = hashCode * 59 + RefundEventList.GetHashCode();
                if (GuaranteeClaimEventList != null)
                    hashCode = hashCode * 59 + GuaranteeClaimEventList.GetHashCode();
                if (ChargebackEventList != null)
                    hashCode = hashCode * 59 + ChargebackEventList.GetHashCode();
                if (PayWithAmazonEventList != null)
                    hashCode = hashCode * 59 + PayWithAmazonEventList.GetHashCode();
                if (ServiceProviderCreditEventList != null)
                    hashCode = hashCode * 59 + ServiceProviderCreditEventList.GetHashCode();
                if (RetrochargeEventList != null)
                    hashCode = hashCode * 59 + RetrochargeEventList.GetHashCode();
                if (RentalTransactionEventList != null)
                    hashCode = hashCode * 59 + RentalTransactionEventList.GetHashCode();
                if (ProductAdsPaymentEventList != null)
                    hashCode = hashCode * 59 + ProductAdsPaymentEventList.GetHashCode();
                if (ServiceFeeEventList != null)
                    hashCode = hashCode * 59 + ServiceFeeEventList.GetHashCode();
                if (SellerDealPaymentEventList != null)
                    hashCode = hashCode * 59 + SellerDealPaymentEventList.GetHashCode();
                if (DebtRecoveryEventList != null)
                    hashCode = hashCode * 59 + DebtRecoveryEventList.GetHashCode();
                if (LoanServicingEventList != null)
                    hashCode = hashCode * 59 + LoanServicingEventList.GetHashCode();
                if (AdjustmentEventList != null)
                    hashCode = hashCode * 59 + AdjustmentEventList.GetHashCode();
                if (SAFETReimbursementEventList != null)
                    hashCode = hashCode * 59 + SAFETReimbursementEventList.GetHashCode();
                if (SellerReviewEnrollmentPaymentEventList != null)
                    hashCode = hashCode * 59 + SellerReviewEnrollmentPaymentEventList.GetHashCode();
                if (FBALiquidationEventList != null)
                    hashCode = hashCode * 59 + FBALiquidationEventList.GetHashCode();
                if (CouponPaymentEventList != null)
                    hashCode = hashCode * 59 + CouponPaymentEventList.GetHashCode();
                if (ImagingServicesFeeEventList != null)
                    hashCode = hashCode * 59 + ImagingServicesFeeEventList.GetHashCode();
                if (NetworkComminglingTransactionEventList != null)
                    hashCode = hashCode * 59 + NetworkComminglingTransactionEventList.GetHashCode();
                if (AffordabilityExpenseEventList != null)
                    hashCode = hashCode * 59 + AffordabilityExpenseEventList.GetHashCode();
                if (AffordabilityExpenseReversalEventList != null)
                    hashCode = hashCode * 59 + AffordabilityExpenseReversalEventList.GetHashCode();
                return hashCode;
            }
        }
    }
}