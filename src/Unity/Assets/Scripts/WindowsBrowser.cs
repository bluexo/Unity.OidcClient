using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assets;
using IdentityModel.OidcClient.Browser;
using UnityEngine;

public class WindowsBrowser : MobileBrowser
{
    protected override void Launch(string url)
    {
        Application.OpenURL(url);
    }
}
