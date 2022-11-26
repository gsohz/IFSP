/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tp_04;
import java.awt.*;
import java.awt.event.*;
import java.util.ArrayList;


public class Form extends Frame implements ActionListener {
    private final Label lNomePesq = new Label("Nome: ");
    private final Label lNomeResult = new Label("Nome: ");
    private final Label lSalario = new Label("Salário: ");
    private final Label lCargo = new Label("Cargo: ");
    private final TextField iNomePesq = new TextField();
    private final TextField iNomeResult = new TextField();
    private final TextField iSalario = new TextField();
    private final TextField iCargo = new TextField();
    private final Button bPesquisar = new Button("Pesquisar");
    private final Button bAnterior = new Button("Anterior");
    private final Button bProximo = new Button("Proximo");
    private final Conexao con = new Conexao();
    private ArrayList<Funcionario> f = new ArrayList<>();
    private int index;

Form(String titulo, int largura, int altura) {
        super(titulo);
        setSize(largura,altura);
        setLocation(550, 300);
        BorderLayout layout = new BorderLayout();
        setLayout(layout);
        setBackground(Color.WHITE);
        addWindowListener(new FechaJanela());
        
        //con.verificarConexao();
        
        //con.criarCargo(1, "Operador");
        //con.criarCargo(2, "Gerente");
        //con.criarCargo(3, "Assistente");
        
        //con.criarFuncionario(3267, "Jose", 1500, 1);
        //con.criarFuncionario(3135, "Jorge", 3500, 2);
        //con.criarFuncionario(1428, "Josefa", 4700, 2);
        //con.criarFuncionario(2244, "Maria", 1520, 1);
        //con.criarFuncionario(6412, "Mauro", 1555, 1);
        //con.criarFuncionario(3146, "Fabricio", 1300, 3);
        
        Panel p1 = new Panel();
        FlowLayout layoutP1 = new FlowLayout();
        p1.setLayout(layoutP1);
        p1.add(lNomePesq);
        iNomePesq.setColumns(15);
        p1.add(iNomePesq);
        
        bPesquisar.addActionListener(this);
        p1.add(bPesquisar);
        
        add(p1, BorderLayout.NORTH);
        
        Panel p2 = new Panel();
        GridLayout layoutP2 = new GridLayout(4, 2);
        p2.setLayout(layoutP2);
        
        p2.add(lNomeResult);
        p2.add(iNomeResult);
        p2.add(lSalario);
        p2.add(iSalario);
        p2.add(lCargo);
        p2.add(iCargo);
        
        add(p2, BorderLayout.CENTER);
        
        
        Panel p3 = new Panel();
        GridLayout layoutP3 = new GridLayout();
        p3.setLayout(layoutP3);
        
        bAnterior.addActionListener(this);
        bProximo.addActionListener(this);
        p2.add(bAnterior);
        p2.add(bProximo);
        
        add(p3, BorderLayout.SOUTH);
        
    }

    public void actionPerformed(ActionEvent e)
    {
        if (e.getSource()== bPesquisar){
            this.f = con.pesquisa(iNomePesq.getText()).getFuncionarios();
            this.index = 0;
            
            iNomeResult.setText(f.get(index).getNome());
            iSalario.setText(f.get(index).getSalario());
            iCargo.setText(f.get(index).getCargo());
            
        } 
        
        if (e.getSource()== bAnterior){
            if(this.index == 0){
                return;
            }
                    
            this.index -= 1;
        
            iNomeResult.setText(f.get(index).getNome());
            iSalario.setText(f.get(index).getSalario());
            iCargo.setText(f.get(index).getCargo());
        } 
        
        if (e.getSource()== bProximo)
        {
            if(index == f.size()-1 || f.isEmpty()){
                return;
            }
            
            this.index += 1;
            
            iNomeResult.setText(f.get(index).getNome());
            iSalario.setText(f.get(index).getSalario());
            iCargo.setText(f.get(index).getCargo());
            
        }
    }
}
