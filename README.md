# Process Planning Notes

## In Progress
* Receipt of Orders
    * `Item.cs` and `ItemGroup.cs` created for documenting items received from orders.
    * Need a means of documenting custodian receipt of items.
* Inventory Management for Serialized Items / Hardware
* Serialized Item / Hardware Transfers
* Site NonSerialized Item Management
    * NonSerialized Item Hand Receipts
* Destruction / Decommissioning of Items

***

## Developed
* Core 
    * `LogUser.cs`
    * `Site.cs`
    * `User.cs`
* Request
    * `Attachment.cs - RequestAttachment`
    * `Priority.cs`
    * `Request.cs`
    * `RequestItem.cs`
* Item Groups
    * `ItemGroup.cs`
    * `ItemGroupCategory.cs`
* Funding
    * `FundingAccount.cs`
    * `FundTransaction.cs`
    * `FundUser.cs`
* Approval Groups and Templates
    * `ApprovalGroup.cs`
    * `ApprovalTemplate.cs`
    * `ApprovalTemplateGroup.cs`
    * `Approver.cs`
    * `ItemGroupApproval.cs`
* Order Placement
    * `Order.cs`
    * `Vendor.cs`
* Property Records
    * `Item.cs`
    * `PropertyRecord.cs`
    * `PropertyCustodian.cs`

***

## Planning Notes
* Plan for how deletion of rows would affect existing records, and how to best mitigate side effects
