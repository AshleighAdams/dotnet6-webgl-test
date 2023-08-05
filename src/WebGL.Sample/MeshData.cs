namespace WebGL.Sample;

public static class MeshData
{
	public static VertexShaderInput[] TriangleVerts { get; } = new VertexShaderInput[]
	{
		new() { Vertex = new(-0.000000f, +0.000000f), Color = new(0f, 0f, 0f) },
		new() { Vertex = new(-0.499997f, +0.499891f), Color = new(0.318f, 0.169f, 0.831f) },
		new() { Vertex = new(+0.499997f, +0.499891f), Color = new(0.318f, 0.169f, 0.831f) },
		new() { Vertex = new(+0.499997f, -0.499891f), Color = new(0.318f, 0.169f, 0.831f) },
		new() { Vertex = new(-0.499997f, -0.499891f), Color = new(0.318f, 0.169f, 0.831f) },
		new() { Vertex = new(-0.321766f, -0.138858f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.323511f, -0.138809f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.325213f, -0.138662f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.326870f, -0.138416f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.328483f, -0.138073f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.330052f, -0.137631f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.331576f, -0.137092f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.333057f, -0.136454f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.334493f, -0.135718f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.335885f, -0.134883f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.337233f, -0.133951f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.338537f, -0.132920f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.339796f, -0.131791f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.340982f, -0.130565f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.342065f, -0.129300f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.343044f, -0.127997f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.343921f, -0.126657f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.344694f, -0.125280f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.345364f, -0.123864f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.345931f, -0.122411f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.346395f, -0.120920f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.346756f, -0.119391f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.347014f, -0.117824f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.347169f, -0.116220f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.347220f, -0.114578f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.347169f, -0.112907f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.347014f, -0.111276f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.346756f, -0.109685f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.346395f, -0.108135f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.345931f, -0.106625f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.345364f, -0.105155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.344694f, -0.103726f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.343921f, -0.102337f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.343044f, -0.100988f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.342065f, -0.099679f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.340982f, -0.098411f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.339796f, -0.097183f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.338537f, -0.096025f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.337233f, -0.094968f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.335885f, -0.094012f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.334493f, -0.093156f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.333057f, -0.092401f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.331576f, -0.091747f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.330052f, -0.091193f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.328483f, -0.090740f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.326870f, -0.090387f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.325213f, -0.090136f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.323511f, -0.089985f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.321766f, -0.089934f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.319992f, -0.089985f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.318265f, -0.090136f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.316584f, -0.090387f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.314950f, -0.090740f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.313363f, -0.091193f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.311823f, -0.091747f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.310329f, -0.092401f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.308881f, -0.093156f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.307481f, -0.094012f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.306127f, -0.094968f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.304819f, -0.096025f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.303559f, -0.097183f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.302345f, -0.098411f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.301236f, -0.099679f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.300233f, -0.100988f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.299336f, -0.102337f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.298544f, -0.103726f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.297858f, -0.105155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.297277f, -0.106625f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.296802f, -0.108135f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.296433f, -0.109685f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.296169f, -0.111276f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.296010f, -0.112907f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.295958f, -0.114578f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.296010f, -0.116220f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.296169f, -0.117824f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.296433f, -0.119391f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.296802f, -0.120920f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.297277f, -0.122411f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.297858f, -0.123864f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.298544f, -0.125280f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.299336f, -0.126657f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.300233f, -0.127997f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.301236f, -0.129300f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.302345f, -0.130565f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.303559f, -0.131791f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.304819f, -0.132920f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.306127f, -0.133951f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.307481f, -0.134883f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.308881f, -0.135718f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.310329f, -0.136454f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.311823f, -0.137092f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.313363f, -0.137631f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.314950f, -0.138073f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.316584f, -0.138416f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.318265f, -0.138662f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.319992f, -0.138809f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.039107f, -0.134872f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.085067f, -0.134872f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.206152f, +0.056115f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.206907f, +0.057327f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.207640f, +0.058546f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.208351f, +0.059773f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.209039f, +0.061008f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.209706f, +0.062250f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.210351f, +0.063500f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.210973f, +0.064757f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.211573f, +0.066022f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.212152f, +0.067294f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.212708f, +0.068574f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213241f, +0.069861f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213753f, +0.071155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213774f, +0.071155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213832f, +0.071155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213919f, +0.071155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.214028f, +0.071155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.214152f, +0.071155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.214284f, +0.071155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.214415f, +0.071155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.214539f, +0.071155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.214649f, +0.071155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.214736f, +0.071155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.214793f, +0.071155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.214814f, +0.071155f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.214588f, +0.069634f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.214382f, +0.067848f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.214196f, +0.065798f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.214029f, +0.063484f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213881f, +0.060906f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213754f, +0.058063f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213645f, +0.054956f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213557f, +0.051585f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213488f, +0.047950f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213439f, +0.044051f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213410f, +0.039887f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213400f, +0.035459f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213400f, +0.032108f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213400f, +0.022842f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213400f, +0.008845f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213400f, -0.008701f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213400f, -0.028612f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213400f, -0.049706f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213400f, -0.070801f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213400f, -0.090712f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213400f, -0.108258f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213400f, -0.122255f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213400f, -0.131521f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.213400f, -0.134872f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.254058f, -0.134872f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.254058f, +0.124973f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.205093f, +0.124973f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.088072f, -0.061484f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.086871f, -0.063367f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.085744f, -0.065149f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.084691f, -0.066831f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.083711f, -0.068411f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.082806f, -0.069891f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.081973f, -0.071270f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.081215f, -0.072549f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.080529f, -0.073727f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079918f, -0.074804f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079380f, -0.075780f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078916f, -0.076656f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078526f, -0.077431f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078512f, -0.077431f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078474f, -0.077431f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078415f, -0.077431f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078343f, -0.077431f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078260f, -0.077431f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078173f, -0.077431f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078085f, -0.077431f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078003f, -0.077431f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.077930f, -0.077431f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.077872f, -0.077431f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.077834f, -0.077431f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.077820f, -0.077431f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078102f, -0.075610f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078359f, -0.073591f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078593f, -0.071372f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078801f, -0.068955f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.078985f, -0.066339f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079145f, -0.063524f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079280f, -0.060510f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079391f, -0.057297f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079477f, -0.053886f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079538f, -0.050275f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079575f, -0.046466f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079587f, -0.042458f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079587f, -0.039164f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079587f, -0.030056f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079587f, -0.016297f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079587f, +0.000950f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079587f, +0.020522f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079587f, +0.041257f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079587f, +0.061992f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079587f, +0.081565f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079587f, +0.098812f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079587f, +0.112571f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079587f, +0.121679f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.079587f, +0.124973f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(-0.039107f, +0.124973f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.158878f, -0.134872f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.016581f, -0.134872f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.016581f, +0.124973f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.153223f, +0.124973f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.153223f, +0.088369f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.058653f, +0.088369f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.058653f, +0.014802f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.145799f, +0.014802f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.145799f, -0.021620f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.058653f, -0.021620f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.058653f, -0.098450f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.158878f, -0.098450f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.361109f, +0.088369f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.288281f, +0.088369f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.288281f, -0.134872f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.246209f, -0.134872f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.246209f, +0.088369f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.173558f, +0.088369f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.173558f, +0.124973f), Color = new(1f, 1f, 1f) },
		new() { Vertex = new(+0.361109f, +0.124973f), Color = new(1f, 1f, 1f) },
	};
	public static ushort[] TriangleIndices { get; } = new ushort[]
	{
		4, 2, 1,
		4, 3, 2,
		52, 54, 53,
		51, 54, 52,
		51, 55, 54,
		50, 55, 51,
		50, 56, 55,
		49, 56, 50,
		49, 57, 56,
		48, 57, 49,
		48, 58, 57,
		47, 58, 48,
		47, 59, 58,
		46, 59, 47,
		46, 60, 59,
		45, 60, 46,
		45, 61, 60,
		44, 61, 45,
		44, 62, 61,
		43, 62, 44,
		43, 63, 62,
		42, 63, 43,
		42, 64, 63,
		41, 64, 42,
		41, 65, 64,
		40, 65, 41,
		40, 66, 65,
		40, 67, 66,
		39, 67, 40,
		39, 68, 67,
		38, 68, 39,
		38, 69, 68,
		37, 69, 38,
		37, 70, 69,
		36, 70, 37,
		36, 71, 70,
		35, 71, 36,
		35, 72, 71,
		34, 72, 35,
		34, 73, 72,
		33, 73, 34,
		33, 74, 73,
		32, 74, 33,
		32, 75, 74,
		31, 75, 32,
		31, 76, 75,
		30, 76, 31,
		30, 77, 76,
		29, 77, 30,
		28, 77, 29,
		28, 78, 77,
		27, 78, 28,
		27, 79, 78,
		26, 79, 27,
		26, 80, 79,
		25, 80, 26,
		25, 81, 80,
		24, 81, 25,
		24, 82, 81,
		23, 82, 24,
		23, 83, 82,
		22, 83, 23,
		22, 84, 83,
		21, 84, 22,
		21, 85, 84,
		20, 85, 21,
		20, 86, 85,
		19, 86, 20,
		19, 87, 86,
		18, 87, 19,
		18, 88, 87,
		17, 88, 18,
		17, 89, 88,
		16, 89, 17,
		16, 90, 89,
		15, 90, 16,
		15, 91, 90,
		14, 91, 15,
		14, 92, 91,
		13, 92, 14,
		13, 93, 92,
		12, 93, 13,
		12, 94, 93,
		11, 94, 12,
		11, 95, 94,
		10, 95, 11,
		10, 96, 95,
		9, 96, 10,
		9, 97, 96,
		8, 97, 9,
		8, 98, 97,
		7, 98, 8,
		7, 99, 98,
		6, 99, 7,
		6, 100, 99,
		5, 100, 6,
		152, 154, 153,
		152, 127, 154,
		127, 126, 154,
		126, 125, 154,
		125, 124, 154,
		124, 123, 154,
		123, 122, 154,
		122, 121, 154,
		121, 120, 154,
		120, 119, 154,
		119, 118, 154,
		118, 117, 154,
		117, 116, 154,
		116, 115, 154,
		115, 155, 154,
		202, 204, 203,
		202, 101, 204,
		201, 101, 202,
		200, 101, 201,
		199, 101, 200,
		198, 101, 199,
		152, 128, 127,
		114, 155, 115,
		113, 155, 114,
		152, 129, 128,
		112, 155, 113,
		152, 130, 129,
		111, 155, 112,
		110, 155, 111,
		152, 131, 130,
		109, 155, 110,
		108, 155, 109,
		152, 132, 131,
		107, 155, 108,
		197, 101, 198,
		106, 155, 107,
		152, 133, 132,
		105, 155, 106,
		104, 155, 105,
		152, 134, 133,
		103, 155, 104,
		102, 155, 103,
		152, 135, 134,
		152, 136, 135,
		152, 137, 136,
		152, 138, 137,
		196, 101, 197,
		152, 139, 138,
		152, 140, 139,
		152, 141, 140,
		152, 142, 141,
		195, 101, 196,
		152, 143, 142,
		194, 101, 195,
		152, 144, 143,
		193, 101, 194,
		152, 145, 144,
		192, 101, 193,
		191, 101, 192,
		190, 101, 191,
		189, 101, 190,
		152, 146, 145,
		188, 101, 189,
		187, 101, 188,
		186, 101, 187,
		185, 101, 186,
		102, 156, 155,
		102, 157, 156,
		184, 101, 185,
		102, 158, 157,
		183, 101, 184,
		102, 159, 158,
		102, 160, 159,
		182, 101, 183,
		102, 161, 160,
		152, 147, 146,
		102, 162, 161,
		181, 101, 182,
		102, 163, 162,
		180, 101, 181,
		102, 164, 163,
		102, 165, 164,
		179, 101, 180,
		102, 166, 165,
		102, 167, 166,
		102, 168, 167,
		102, 169, 168,
		102, 170, 169,
		102, 171, 170,
		102, 172, 171,
		102, 173, 172,
		102, 174, 173,
		102, 175, 174,
		102, 176, 175,
		102, 177, 176,
		102, 178, 177,
		102, 179, 178,
		102, 101, 179,
		152, 148, 147,
		152, 149, 148,
		152, 150, 149,
		152, 151, 150,
		206, 210, 207,
		210, 208, 207,
		210, 209, 208,
		206, 211, 210,
		206, 214, 211,
		214, 212, 211,
		214, 213, 212,
		206, 215, 214,
		206, 216, 215,
		206, 205, 216,
		222, 224, 223,
		222, 217, 224,
		221, 217, 222,
		220, 218, 221,
		218, 217, 221,
		220, 219, 218,
	};
}
