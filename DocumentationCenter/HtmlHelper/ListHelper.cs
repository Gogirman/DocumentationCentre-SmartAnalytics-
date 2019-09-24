using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace DocumentationCenter.Models
{
    //HTML хелпер
    public static class ListHelper
    {
        public static HtmlString CreateList(this IHtmlHelper html, AbstractFile file)
        {
            TagBuilder li = new TagBuilder("li");
            TagBuilder a = new TagBuilder("a");
            TagBuilder deleteButton = new TagBuilder("button");
            TagBuilder deleteImage = new TagBuilder("img");
            TagBuilder photo = new TagBuilder("img");
            TagBuilder name = new TagBuilder("p");
            TagBuilder input = new TagBuilder("input");
            TagBuilder label = new TagBuilder("label");
            deleteButton.Attributes.Add("class", "deleteFile");
            deleteButton.Attributes.Add("parametre", file.Id.ToString());
            photo.Attributes.Add("src", file.BaseIcon);
            deleteImage.Attributes.Add("src", "http://s1.iconbird.com/ico/2013/9/452/w448h5121380477116trash.png");
            photo.AddCssClass("elementPhoto");
            name.AddCssClass("elementText");
            deleteImage.AddCssClass("elementPhoto");
            name.InnerHtml.Append(file.Name);
            label.AddCssClass("btn btn-secondary active");
            input.Attributes.Add("type", "IsSelected");
            input.Attributes.Add("checked autocomplete", "off");
            input.AddCssClass("elementCheck");
            li.Attributes.Add("id", file.Id.ToString());
            deleteButton.InnerHtml.AppendHtml(deleteImage);
            a.InnerHtml.AppendHtml(input);
            if (file is Folder)
                a.AddCssClass("folder");
            else
                a.AddCssClass("asd");
            a.InnerHtml.AppendHtml(photo);
            a.InnerHtml.AppendHtml(name);
            a.InnerHtml.AppendHtml(deleteButton);

            a.Attributes.Add("primarykey", file.Id.ToString());

            a.AddCssClass("btn btn-primary active");
            a.AddCssClass("list-group-item");
            a.Attributes.Add("role", "button");
            li.InnerHtml.AppendHtml(a);
            var writer = new System.IO.StringWriter();
            li.WriteTo(writer, HtmlEncoder.Default);

            return new HtmlString(writer.ToString());
        }

    }
}
