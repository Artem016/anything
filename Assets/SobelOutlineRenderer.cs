using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public sealed class SobelOutlineRenderer : PostProcessEffectRenderer<SobelOutline>
{
    public override void Render(PostProcessRenderContext context)
    {
        var sheet = context.propertySheets.Get(Shader.Find("PostProcessing/SobelOutline"));

        sheet.properties.SetFloat("_OutlineThickness", settings.thickness);
        sheet.properties.SetFloat("_OutlineDepthMultiplier", settings.depthMultiplier);
        sheet.properties.SetFloat("_OutlineDepthBias", settings.depthBias);
        sheet.properties.SetFloat("_OutlineNormalMultiplier", settings.normalMultiplier);
        sheet.properties.SetFloat("_OutlineNormalBias", settings.normalBias);
        sheet.properties.SetColor("_OutlineColor", settings.color);

        context.command.BlitFullscreenTriangle(context.source, context.destination, sheet, 0);
    }
}
