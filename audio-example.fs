// set the color
#define fg vec3(0,255,255) // foreground
#define bg vec3(0,0,255) // background
// set audio buffer average size
#define sb int(10) // starting audio buffer
#define eb int(32) // ending audio buffer

void mainImage( out vec4 fragColor, in vec2 fragCoord )
{
    vec2 uv = fragCoord.xy / iResolution.xy;
    vec3 far = fg/255;
    vec3 close = bg/255;
    float avg = 0.;
    for (int i = sb; i < eb; i++){
        avg += abs(iAudio[i]);
    }
    avg /= eb-sb;
    fragColor = vec4(avg*far+(1.-avg)*close,1.);
}
