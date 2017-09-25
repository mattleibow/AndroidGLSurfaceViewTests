using Android.App;
using Android.Opengl;
using Android.OS;
using Android.Support.V7.App;
using Javax.Microedition.Khronos.Opengles;

namespace AndroidGLTests
{
	[Activity(Label = "@string/app_name", Theme = "@style/splashscreen", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.SetTheme(Resource.Style.MainTheme);

			base.OnCreate(savedInstanceState);

			var renderer = new Renderer();

			var glview = new GLSurfaceView(this);
			glview.SetRenderer(renderer);

			SetContentView(glview);
		}

		private class Renderer : Java.Lang.Object, GLSurfaceView.IRenderer
		{
			public void OnDrawFrame(IGL10 gl)
			{
				GLES20.GlClearColor(1, 1, 1, 1);
				GLES20.GlClear(GLES20.GlStencilBufferBit | GLES20.GlColorBufferBit);
			}

			public void OnSurfaceChanged(IGL10 gl, int width, int height)
			{
				GLES20.GlViewport(0, 0, width, height);
			}

			public void OnSurfaceCreated(IGL10 gl, Javax.Microedition.Khronos.Egl.EGLConfig config)
			{
			}
		}
	}
}
