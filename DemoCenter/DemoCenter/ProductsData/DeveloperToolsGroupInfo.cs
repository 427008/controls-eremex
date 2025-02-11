using DemoCenter.ViewModels;
using System.Collections.Generic;

namespace DemoCenter.ProductsData;

public class DeveloperToolsGroupInfo
{
    internal static List<PageInfo> Create()
    {
        return new List<PageInfo>()
        {
            new PageInfo(name: "SVG Icons Browser", title: "Svg Icons Browser",
                description: "",
                viewModelGetter: () => new SvgIconsBrowserViewModel())
        };
    }
}