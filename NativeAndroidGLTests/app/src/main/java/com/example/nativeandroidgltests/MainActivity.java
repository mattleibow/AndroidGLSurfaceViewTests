package com.example.nativeandroidgltests;

import android.opengl.GLES20;
import android.opengl.GLSurfaceView;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

import javax.microedition.khronos.egl.EGLConfig;
import javax.microedition.khronos.opengles.GL10;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.setTheme(R.style.MainTheme);

        super.onCreate(savedInstanceState);

        GLSurfaceView.Renderer renderer = new GLSurfaceView.Renderer(){
            @Override
            public void onSurfaceCreated(GL10 gl10, EGLConfig eglConfig) {
            }
            @Override
            public void onSurfaceChanged(GL10 gl10, int width, int height) {
                GLES20.glViewport(0, 0, width, height);
            }
            @Override
            public void onDrawFrame(GL10 gl10) {
                GLES20.glClearColor(1, 1, 1, 1);
                GLES20.glClear(GLES20.GL_STENCIL_BUFFER_BIT | GLES20.GL_COLOR_BUFFER_BIT);
            }
        };

        GLSurfaceView glview = new GLSurfaceView(this);
        glview.setRenderer(renderer);

        setContentView(glview);
    }
}
