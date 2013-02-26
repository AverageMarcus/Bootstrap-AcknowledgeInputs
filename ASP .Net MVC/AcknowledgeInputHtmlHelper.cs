using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

public static class AcknowledgeInputHtmlHelper
{


    public static MvcHtmlString AcknowledgeTextboxFor<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression, object containerHtmlAttributes = null, object inputHtmlAttributes = null, string dataType = "text")
    {
        IDictionary<string, object> containerAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(containerHtmlAttributes);

        if (containerAttribs == null)
        {
            containerAttribs = new Dictionary<string, object>();
        }

        IDictionary<string, object> inputAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(inputHtmlAttributes);

        if (inputAttribs == null)
        {
            inputAttribs = new Dictionary<string, object>();
        }
        inputAttribs.Add("data-type", dataType);

        TagBuilder containerBuilder = new TagBuilder("div");
        containerBuilder.MergeAttributes(containerAttribs);
        containerBuilder.Attributes.Add("data-role", "acknowledge-input");
        containerBuilder.AddCssClass("input-append");
        containerBuilder.InnerHtml = helper.TextBoxFor(expression, inputAttribs).ToHtmlString() + "<div data-role='acknowledgement'><i></i></div>";

        return new MvcHtmlString(containerBuilder.ToString());
    }

    public static MvcHtmlString AcknowledgeTextbox<TModel, TProperty>(this HtmlHelper<TModel> helper, string name, string value, string format = "", object containerHtmlAttributes = null, object inputHtmlAttributes = null, string dataType = "text")
    {
        IDictionary<string, object> containerAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(containerHtmlAttributes);

        if (containerAttribs == null)
        {
            containerAttribs = new Dictionary<string, object>();
        }

        IDictionary<string, object> inputAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(inputHtmlAttributes);

        if (inputAttribs == null)
        {
            inputAttribs = new Dictionary<string, object>();
        }
        inputAttribs.Add("data-type", dataType);

        TagBuilder containerBuilder = new TagBuilder("div");
        containerBuilder.MergeAttributes(containerAttribs);
        containerBuilder.Attributes.Add("data-role", "acknowledge-input");
        containerBuilder.AddCssClass("input-append");
        containerBuilder.InnerHtml = helper.TextBox(name, value, inputAttribs).ToHtmlString() + "<div data-role='acknowledgement'><i></i></div>";

        return new MvcHtmlString(containerBuilder.ToString());
    }

    public static MvcHtmlString AcknowledgePasswordFor<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression, object containerHtmlAttributes = null, object inputHtmlAttributes = null, string dataType = "text")
    {
        IDictionary<string, object> containerAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(containerHtmlAttributes);

        if (containerAttribs == null)
        {
            containerAttribs = new Dictionary<string, object>();
        }

        IDictionary<string, object> inputAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(inputHtmlAttributes);

        if (inputAttribs == null)
        {
            inputAttribs = new Dictionary<string, object>();
        }
        inputAttribs.Add("data-type", dataType);

        TagBuilder containerBuilder = new TagBuilder("div");
        containerBuilder.MergeAttributes(containerAttribs);
        containerBuilder.Attributes.Add("data-role", "acknowledge-input");
        containerBuilder.AddCssClass("input-append");
        containerBuilder.InnerHtml = helper.PasswordFor(expression, inputAttribs).ToHtmlString() + "<div data-role='acknowledgement'><i></i></div>";

        return new MvcHtmlString(containerBuilder.ToString());
    }

    public static MvcHtmlString AcknowledgePassword<TModel, TProperty>(this HtmlHelper<TModel> helper, string name, string value, string format = "", object containerHtmlAttributes = null, object inputHtmlAttributes = null, string dataType = "text")
    {
        IDictionary<string, object> containerAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(containerHtmlAttributes);

        if (containerAttribs == null)
        {
            containerAttribs = new Dictionary<string, object>();
        }

        IDictionary<string, object> inputAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(inputHtmlAttributes);

        if (inputAttribs == null)
        {
            inputAttribs = new Dictionary<string, object>();
        }
        inputAttribs.Add("data-type", dataType);

        TagBuilder containerBuilder = new TagBuilder("div");
        containerBuilder.MergeAttributes(containerAttribs);
        containerBuilder.Attributes.Add("data-role", "acknowledge-input");
        containerBuilder.AddCssClass("input-append");
        containerBuilder.InnerHtml = helper.Password(name, value, inputAttribs).ToHtmlString() + "<div data-role='acknowledgement'><i></i></div>";

        return new MvcHtmlString(containerBuilder.ToString());
    }

    public static MvcHtmlString AcknowledgeTextAreaFor<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression, int rows, int columns, object containerHtmlAttributes = null, object inputHtmlAttributes = null, string dataType = "text")
    {
        IDictionary<string, object> containerAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(containerHtmlAttributes);

        if (containerAttribs == null)
        {
            containerAttribs = new Dictionary<string, object>();
        }

        IDictionary<string, object> inputAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(inputHtmlAttributes);

        if (inputAttribs == null)
        {
            inputAttribs = new Dictionary<string, object>();
        }
        inputAttribs.Add("data-type", dataType);

        TagBuilder containerBuilder = new TagBuilder("div");
        containerBuilder.MergeAttributes(containerAttribs);
        containerBuilder.Attributes.Add("data-role", "acknowledge-input");
        containerBuilder.AddCssClass("input-append");
        containerBuilder.InnerHtml = helper.TextAreaFor(expression, rows, columns, inputAttribs).ToHtmlString() + "<div data-role='acknowledgement'><i></i></div>";

        return new MvcHtmlString(containerBuilder.ToString());
    }

    public static MvcHtmlString AcknowledgeTextArea<TModel, TProperty>(this HtmlHelper<TModel> helper, string name, string value, int rows, int columns, object containerHtmlAttributes = null, object inputHtmlAttributes = null, string dataType = "text")
    {
        IDictionary<string, object> containerAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(containerHtmlAttributes);

        if (containerAttribs == null)
        {
            containerAttribs = new Dictionary<string, object>();
        }

        IDictionary<string, object> inputAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(inputHtmlAttributes);

        if (inputAttribs == null)
        {
            inputAttribs = new Dictionary<string, object>();
        }
        inputAttribs.Add("data-type", dataType);

        TagBuilder containerBuilder = new TagBuilder("div");
        containerBuilder.MergeAttributes(containerAttribs);
        containerBuilder.Attributes.Add("data-role", "acknowledge-input");
        containerBuilder.AddCssClass("input-append");
        containerBuilder.InnerHtml = helper.TextArea(name, value, rows, columns, inputAttribs).ToHtmlString() + "<div data-role='acknowledgement'><i></i></div>";

        return new MvcHtmlString(containerBuilder.ToString());
    }

    public static MvcHtmlString AcknowledgeDropdownFor<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, object containerHtmlAttributes = null, object inputHtmlAttributes = null, string dataType = "text")
    {
        IDictionary<string, object> containerAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(containerHtmlAttributes);

        if (containerAttribs == null)
        {
            containerAttribs = new Dictionary<string, object>();
        }

        IDictionary<string, object> inputAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(inputHtmlAttributes);

        if (inputAttribs == null)
        {
            inputAttribs = new Dictionary<string, object>();
        }
        inputAttribs.Add("data-type", dataType);

        TagBuilder containerBuilder = new TagBuilder("div");
        containerBuilder.MergeAttributes(containerAttribs);
        containerBuilder.Attributes.Add("data-role", "acknowledge-input");
        containerBuilder.AddCssClass("input-append");
        containerBuilder.InnerHtml = helper.DropDownListFor(expression, selectList, inputAttribs).ToHtmlString() + "<div data-role='acknowledgement'><i></i></div>";

        return new MvcHtmlString(containerBuilder.ToString());
    }

    public static MvcHtmlString AcknowledgeDropdown<TModel, TProperty>(this HtmlHelper<TModel> helper, string name, string optionLabel, IEnumerable<SelectListItem> selectList, object containerHtmlAttributes = null, object inputHtmlAttributes = null, string dataType = "text")
    {
        IDictionary<string, object> containerAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(containerHtmlAttributes);

        if (containerAttribs == null)
        {
            containerAttribs = new Dictionary<string, object>();
        }

        IDictionary<string, object> inputAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(inputHtmlAttributes);

        if (inputAttribs == null)
        {
            inputAttribs = new Dictionary<string, object>();
        }
        inputAttribs.Add("data-type", dataType);

        TagBuilder containerBuilder = new TagBuilder("div");
        containerBuilder.MergeAttributes(containerAttribs);
        containerBuilder.Attributes.Add("data-role", "acknowledge-input");
        containerBuilder.AddCssClass("input-append");
        containerBuilder.InnerHtml = helper.DropDownList(name, selectList, optionLabel, inputAttribs).ToHtmlString() + "<div data-role='acknowledgement'><i></i></div>";

        return new MvcHtmlString(containerBuilder.ToString());
    }

    public static MvcHtmlString AcknowledgeListBoxFor<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, object containerHtmlAttributes = null, object inputHtmlAttributes = null, string dataType = "text")
    {
        IDictionary<string, object> containerAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(containerHtmlAttributes);

        if (containerAttribs == null)
        {
            containerAttribs = new Dictionary<string, object>();
        }

        IDictionary<string, object> inputAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(inputHtmlAttributes);

        if (inputAttribs == null)
        {
            inputAttribs = new Dictionary<string, object>();
        }
        inputAttribs.Add("data-type", dataType);

        TagBuilder containerBuilder = new TagBuilder("div");
        containerBuilder.MergeAttributes(containerAttribs);
        containerBuilder.Attributes.Add("data-role", "acknowledge-input");
        containerBuilder.AddCssClass("input-append");
        containerBuilder.InnerHtml = helper.ListBoxFor(expression, selectList, inputAttribs).ToHtmlString() + "<div data-role='acknowledgement'><i></i></div>";

        return new MvcHtmlString(containerBuilder.ToString());
    }

    public static MvcHtmlString AcknowledgeListBox<TModel, TProperty>(this HtmlHelper<TModel> helper, string name, IEnumerable<SelectListItem> selectList, object containerHtmlAttributes = null, object inputHtmlAttributes = null, string dataType = "text")
    {
        IDictionary<string, object> containerAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(containerHtmlAttributes);

        if (containerAttribs == null)
        {
            containerAttribs = new Dictionary<string, object>();
        }

        IDictionary<string, object> inputAttribs = HtmlHelper.AnonymousObjectToHtmlAttributes(inputHtmlAttributes);

        if (inputAttribs == null)
        {
            inputAttribs = new Dictionary<string, object>();
        }
        inputAttribs.Add("data-type", dataType);

        TagBuilder containerBuilder = new TagBuilder("div");
        containerBuilder.MergeAttributes(containerAttribs);
        containerBuilder.Attributes.Add("data-role", "acknowledge-input");
        containerBuilder.AddCssClass("input-append");
        containerBuilder.InnerHtml = helper.ListBox(name, selectList, inputAttribs).ToHtmlString() + "<div data-role='acknowledgement'><i></i></div>";

        return new MvcHtmlString(containerBuilder.ToString());
    }


}