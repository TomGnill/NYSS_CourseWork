// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NYSS_CourseWork.WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andri\Documents\repos\NYSS_CourseWork\NYSS_CourseWork.WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andri\Documents\repos\NYSS_CourseWork\NYSS_CourseWork.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andri\Documents\repos\NYSS_CourseWork\NYSS_CourseWork.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andri\Documents\repos\NYSS_CourseWork\NYSS_CourseWork.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andri\Documents\repos\NYSS_CourseWork\NYSS_CourseWork.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andri\Documents\repos\NYSS_CourseWork\NYSS_CourseWork.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andri\Documents\repos\NYSS_CourseWork\NYSS_CourseWork.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andri\Documents\repos\NYSS_CourseWork\NYSS_CourseWork.WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andri\Documents\repos\NYSS_CourseWork\NYSS_CourseWork.WebApp\_Imports.razor"
using NYSS_CourseWork.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\andri\Documents\repos\NYSS_CourseWork\NYSS_CourseWork.WebApp\_Imports.razor"
using NYSS_CourseWork.WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andri\Documents\repos\NYSS_CourseWork\NYSS_CourseWork.WebApp\Pages\CryptPage.razor"
using NYSS_CourseWork.Scrambler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andri\Documents\repos\NYSS_CourseWork\NYSS_CourseWork.WebApp\Pages\CryptPage.razor"
using NYSS_CourseWork.WebApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cryptpage")]
    public partial class CryptPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\andri\Documents\repos\NYSS_CourseWork\NYSS_CourseWork.WebApp\Pages\CryptPage.razor"
       
    private BranchingEnums.InputChoise InputChoise { get; set; } = BranchingEnums.InputChoise.none;
    private BranchingEnums.OutputVar OutputChoise { get; set; } = BranchingEnums.OutputVar.none;
    private BranchingEnums.CryptFunc DecryptOrEncrypt { get; set; } = BranchingEnums.CryptFunc.none;
    private BranchingEnums.CryptLanguage Language { get; set; } = BranchingEnums.CryptLanguage.Russian;
    private Alphabet alphabet = new RussianAlphabet();
    private string FilePath { get; set; }
    private string Text { get; set; }
    private string Result { get; set; }
    private string Key { get; set; } = "??????????????????????";

    private async Task InputFromFile()
    {
        FileManagerController newManager = new FileManagerController();
        Text = await newManager.ReadTxtFile(FilePath);
        Text = Text.ToString();
    }
    private async Task InputOnFile()
    {
        FileManagerController newManager = new FileManagerController();
        await newManager.SaveTxtFile(FilePath, Result);
    }

    private void ChangeInputTxt()
    {
        InputChoise = BranchingEnums.InputChoise.fromTxt;
    }
    private void ChangeInputKeyboard()
    {
        InputChoise = BranchingEnums.InputChoise.fromKeyboard;
    }
    private void ChangeEncrypt()
    {
        DecryptOrEncrypt = BranchingEnums.CryptFunc.encrypt;
    }
    private void ChangeDecrypt()
    {
        DecryptOrEncrypt = BranchingEnums.CryptFunc.decrypt;
    }

    private void ChangeOutputTxt()
    {
        OutputChoise = BranchingEnums.OutputVar.outTxt;
    }
    private void ChangeOutputMonitor()
    {
        OutputChoise = BranchingEnums.OutputVar.onMonitor;
    }
    private void ChangeAlphabet()
    {
        if (Language == BranchingEnums.CryptLanguage.Russian)
        {
            Language = BranchingEnums.CryptLanguage.English;
            alphabet = new EnglishAlphabet();
        }
        else
        {
            Language = BranchingEnums.CryptLanguage.Russian;
            alphabet = new RussianAlphabet();
        }
    }

    private async Task Run()
    {
        ScramblerMaster newMaster = new ScramblerMaster();


        if (DecryptOrEncrypt == BranchingEnums.CryptFunc.decrypt)
        {
            Result = await newMaster.GetDecryption(Key, Text, alphabet);
        }
        if (DecryptOrEncrypt == BranchingEnums.CryptFunc.encrypt)
        {
            Result = await newMaster.GetEncryption(Key, Text, alphabet);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
