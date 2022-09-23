/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.tp_02;
import java.awt.*;
import java.awt.event.*;
import java.util.ArrayList;
import javax.swing.JOptionPane;
/**
 *
 * @author gabri
 */
class Form extends Frame implements ActionListener {
    private final Label lNome = new Label("Nome: ");
    private final Label lIdade = new Label("Idade: ");
    private final Label lEndereco = new Label("Endereço: ");
    private final TextField inputNome = new TextField(15);
    private final TextField inputIdade = new TextField(15);
    private final TextField inputEndereco = new TextField(15);
    private final Button bOk = new Button("Ok");
    private final Button bLimpar = new Button("Limpar");
    private final Button bMostrar = new Button("Mostrar");
    private final Button bSair = new Button("Sair");
    private final ArrayList<Aluno> lista;
   

    Form(String titulo, int largura, int altura) {
        super(titulo);
        this.lista = new ArrayList<>();
        setSize(largura,altura);
        setLocation(550, 300);
        setLayout(new BorderLayout());
        setBackground(Color.LIGHT_GRAY);
        addWindowListener(new FechaJanela());
        
        Panel p1 = new Panel();
        GridLayout layoutP1 = new GridLayout(3,2);
        layoutP1.setHgap(10);
        layoutP1.setVgap(10);
        p1.setLayout(layoutP1);
        
        Panel p2 = new Panel();
        GridLayout layoutP2 = new GridLayout();
        p2.setLayout(layoutP2);
        
        bOk.addActionListener(this);
        bLimpar.addActionListener(this);
        bMostrar.addActionListener(this);
        bSair.addActionListener(this);
        p1.add(lNome);
        p1.add(inputNome);
        p1.add(lIdade);
        p1.add(inputIdade);
        p1.add(lEndereco);
        p1.add(inputEndereco);
        add(p1, BorderLayout.CENTER);
        
        p2.add(bOk);
        p2.add(bLimpar);
        p2.add(bMostrar);
        p2.add(bSair);
        add(p2, BorderLayout.SOUTH);
    }
    
    public void actionPerformed(ActionEvent e)
    {
        if (e.getSource()== bSair)
        {
            System.exit(0);
        }
        else if (e.getSource()== bOk)
        {
            String nome = inputNome.getText();
            int idade = Integer.parseInt(inputIdade.getText());
            String endereco = inputEndereco.getText();
            
            Aluno aluno = new Aluno(nome, endereco, idade);
            lista.add(aluno);
            JOptionPane.showMessageDialog(this, "Adicionado com sucesso");
            this.inputIdade.setText("");
            this.inputEndereco.setText("");
            this.inputNome.setText("");
        }
        else if (e.getSource()== bLimpar)
        {
            this.lNome.setText("");
            this.lEndereco.setText("");
            this.lIdade.setText("");
        }
        else if (e.getSource() == bMostrar){
            String resultado = "";
            for(Aluno a : lista){
                resultado += "ID: " + a.getUuid() + " Nome: " + a.getNome() + "\n";
            }
            JOptionPane.showMessageDialog(this, resultado);
        }
    }
}
