package com.example.fit;

import androidx.appcompat.app.AppCompatActivity;
import androidx.cardview.widget.CardView;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    CardView cardViewAbonuesi;
    CardView cardViewShtoAbonuesin;
    CardView cardViewProduct;
    CardView cardViewShtoProduktin;
    CardView cardViewPerdoruesi;
    CardView cardViewShtoPerdoruesin;
    CardView cardViewTraineri;
    CardView cardViewAddTraineri;
    CardView cardViewHytjet;
    CardView cardViewHyrjet;
    CardView cardViewMbikqyresi;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        cardViewAbonuesi = (CardView) findViewById(R.id.idAbonuesi);
        cardViewShtoAbonuesin = (CardView) findViewById(R.id.idShtoAbonuesin);
        cardViewProduct = (CardView) findViewById(R.id.idProduktiActivityMain);
        cardViewPerdoruesi = (CardView) findViewById(R.id.idPerdouresi);
        cardViewShtoPerdoruesin = (CardView) findViewById(R.id.idTrainer);
        cardViewTraineri = (CardView) findViewById(R.id.idTraineriMain);
        cardViewAddTraineri = (CardView) findViewById(R.id.idHyrjet);
        cardViewHytjet = (CardView) findViewById(R.id.idShitjet);
        cardViewShtoProduktin = (CardView) findViewById(R.id.idShtoProduktin);
        cardViewHyrjet = (CardView) findViewById(R.id.idHyrjetCardView);
        cardViewMbikqyresi = (CardView) findViewById(R.id.idMbikqyresiCarcView);

        /*cardViewAbonuesi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, AbonuesiActivity.class);
                startActivity(intent);
            }
        });

        cardViewShtoAbonuesin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, AddAbonuesi.class);
                startActivity(intent);
            }
        });

        cardViewProduct.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, ProduktiActivity.class);
                startActivity(intent);
            }
        });

        cardViewShtoProduktin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, AddProdukti.class);
                startActivity(intent);
            }
        });

        cardViewPerdoruesi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, PerdoruesiActivity.class);
                startActivity(intent);
            }
        });

        cardViewShtoPerdoruesin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, AddPerdoreusi.class);
                startActivity(intent);
            }
        });

        cardViewTraineri.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, TrainerActivity.class);
                startActivity(intent);
            }
        });

        cardViewAddTraineri.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, AddTraineri.class);
                startActivity(intent);
            }
        });

        cardViewHytjet.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, SalesActivity.class);
                startActivity(intent);
            }
        });

        cardViewHyrjet.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, HyrjetActivity.class);
                startActivity(intent);
            }
        });

        cardViewMbikqyresi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, MbikqyresiActivity.class);
                startActivity(intent);
            }
        });*/

    }
}
