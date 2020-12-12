package com.example.fit;

import android.content.Intent;
import android.media.Image;
import android.os.Bundle;
import android.os.Handler;
import android.view.WindowManager;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class SplashActivity extends AppCompatActivity {

    private static int SPLASH_SCREEN = 2000;

    Animation topAnim,bottomAnim;
    ImageView image;
    TextView logo,slogan1;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,WindowManager.LayoutParams.ALPHA_CHANGED);
        setContentView(R.layout.splash_screen);

        topAnim = AnimationUtils.loadAnimation(this,R.anim.top_animation);
        bottomAnim = AnimationUtils.loadAnimation(this,R.anim.bottom_animation);

        image = findViewById(R.id.logoSpash);
        logo = findViewById(R.id.textSplash);
        slogan1 = findViewById(R.id.textSplash2);

        image.setAnimation(topAnim);
        logo.setAnimation(bottomAnim);
        slogan1.setAnimation(bottomAnim);

        new Handler().postDelayed(new Runnable() {
            @Override
            public void run() {
                Intent i = new Intent(SplashActivity.this,MainActivity.class);
                startActivity(i);
                finish();
            }
        },SPLASH_SCREEN);


    }
}
