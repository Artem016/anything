using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(SobelOutlineRenderer), PostProcessEvent.BeforeStack, "SobelOutline")]
public class SobelOutline : PostProcessEffectSettings
{
    public FloatParameter thickness = new FloatParameter { value = 1.0f };
    public FloatParameter depthMultiplier = new FloatParameter { value = 1.0f };
    public FloatParameter depthBias = new FloatParameter { value = 1.0f };
    public FloatParameter normalMultiplier = new FloatParameter { value = 1.0f };
    public FloatParameter normalBias = new FloatParameter { value = 10.0f };
    public ColorParameter color = new ColorParameter { value = Color.black };
}
