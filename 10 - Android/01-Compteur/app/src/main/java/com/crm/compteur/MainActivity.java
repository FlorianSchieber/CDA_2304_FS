package com.crm.compteur;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

    private static Integer DEFAULT_COUNT_VALUE = 0;
    private static Integer START_COUNT_VALUE = 10;
    private int countValue;

    private Button decButton;
    private Button incButton;
    private EditText countEditText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.countValue = MainActivity.START_COUNT_VALUE;
        setContentView(R.layout.activity_main);

        this.decButton = (Button) findViewById(R.id.dec);
        this.incButton = (Button) findViewById(R.id.inc);
        this.countEditText = (EditText) findViewById(R.id.count);

        this.countEditText.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {

            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                inputCount();
            }

            @Override
            public void afterTextChanged(Editable s) {

            }
        });

        this.outputCount();

    }

    public void inputCount() {
        String countText = this.countEditText.getText().toString();
        if(MainActivity.tryParseInt(countText) != null){
            this.countEditText.setError("Veuillez saisir un nombre entier valide");
            this.countValue = MainActivity.DEFAULT_COUNT_VALUE;
        }
        else {
            this.countEditText.setError(null);
            int newCountValue = Integer.parseInt(countText);
            this.countValue = newCountValue;
        }
    }

    public void outputCount() {
        this.countEditText.setError(null);
        String newCountText = Integer.toString(this.countValue);
        this.countEditText.setText(newCountText);
        this.countEditText.setText(newCountText);
    }

    public void incrementCount(View v) {
        this.countValue++;
        this.outputCount();
    }

    public void decrementCount(View v) {
        this.countValue--;
        this.outputCount();
    }

    public static Integer tryParseInt(String s) {
        try {
            return Integer.parseInt(s);
        } catch (NumberFormatException e) {
            return null;
        }
    }
}