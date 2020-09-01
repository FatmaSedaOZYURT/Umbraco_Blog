//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.6.4
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "contactFormControls"
	/// <summary>Contact Form Controls</summary>
	public partial interface IContactFormControls : IPublishedContent
	{
		/// <summary>Error Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		global::System.Web.IHtmlString ErrorMessage { get; }

		/// <summary>Succes Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		global::System.Web.IHtmlString SuccesMessage { get; }
	}

	/// <summary>Contact Form Controls</summary>
	[PublishedModel("contactFormControls")]
	public partial class ContactFormControls : PublishedContentModel, IContactFormControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "contactFormControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactFormControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContactFormControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Error Message: Hata mesajı gir
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("errorMessage")]
		public global::System.Web.IHtmlString ErrorMessage => GetErrorMessage(this);

		/// <summary>Static getter for Error Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static global::System.Web.IHtmlString GetErrorMessage(IContactFormControls that) => that.Value<global::System.Web.IHtmlString>("errorMessage");

		///<summary>
		/// Succes Message: Başarı mesajı gir
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("succesMessage")]
		public global::System.Web.IHtmlString SuccesMessage => GetSuccesMessage(this);

		/// <summary>Static getter for Succes Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static global::System.Web.IHtmlString GetSuccesMessage(IContactFormControls that) => that.Value<global::System.Web.IHtmlString>("succesMessage");
	}
}
