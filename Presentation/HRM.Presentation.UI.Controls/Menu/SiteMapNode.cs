﻿using System.Collections.Generic;
using System.Web.Routing;

//code from Telerik MVC Extensions
namespace HRM.Presentation.UI.Controls.Menu
{
    public class SiteMapNode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteMapNode"/> class.
        /// </summary>
        public SiteMapNode()
        {
            RouteValues = new RouteValueDictionary();
            ChildNodes = new List<SiteMapNode>();
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }
        public string NopResource { get; set; }

        /// <summary>
        /// Gets or sets the name of the controller.
        /// </summary>
        /// <value>The name of the controller.</value>
        public string ControllerName { get; set; }

        /// <summary>
        /// Gets or sets the name of the action.
        /// </summary>
        /// <value>The name of the action.</value>
        public string ActionName { get; set; }

        /// <summary>
        /// Gets or sets the route values.
        /// </summary>
        /// <value>The route values.</value>
        public RouteValueDictionary RouteValues { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the child nodes.
        /// </summary>
        /// <value>The child nodes.</value>
        public IList<SiteMapNode> ChildNodes { get; set; }

        /// <summary>
        /// Gets or sets hrm website
        /// </summary>
        /// <value>The name of the image path.</value>
        public string HrmWebSite { get; set; }

        /// <summary>
        /// Gets or sets the image path
        /// </summary>
        /// <value>The name of the image path.</value>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the item is visible
        /// </summary>
        /// <value>A value indicating whether the item is visible</value>
        public bool Visible { get; set; }

        public string Alias { get; set; }
        public string Parent { get; set; }
        public string ModuleName { get; set; }
    }
}