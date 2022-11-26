/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tp_04;
import java.sql.*;
/**
 *
 * @author gabri
 */
public class Conexao {
    private final String url = "jdbc:mysql://127.0.0.1:3306/aulajava";
    private final String usuario = "root";
    private final String senha = "123456";
    
    public void verificarConexao(){
        try
      {
        Class.forName("com.mysql.cj.jdbc.Driver");

        Connection con;
        con = DriverManager.getConnection(url, usuario, senha);
        System.out.println ("Conexao OK");

        DatabaseMetaData db = con.getMetaData();
        System.out.println("Conectado a "+db.getURL());
        System.out.println("Conexao     "+db.getConnection());
        System.out.println("Driver      "+db.getDriverName());
        System.out.println("Usuario     "+db.getUserName());
        System.out.println("----------------------------------");

        con.close();
      }
      catch (Exception e)
      {
        System.out.println("Erro: " + e.getMessage());
      }
    }
    
    private static void salvaRS(ResultSet rs) throws SQLException
    {
        int i;
        ResultSetMetaData rsmd = rs.getMetaData();
        int numcols = rsmd.getColumnCount();
        
        while (rs.next())
        {
            for (i=1;i<=numcols;i++)
            {
                System.out.print(rs.getString(i) + " - ");
            }
            System.out.print("\n");
        }
    }
    
    public void criarCargo(int cd_cargo, String ds_cargo){
      try
      {
        Class.forName("com.mysql.cj.jdbc.Driver");

        Connection con;
        con = DriverManager.getConnection(url, usuario, senha);
        
        String st = "INSERT INTO tbcargos(cd_cargo, ds_cargo) VALUES (?, ?)";
        PreparedStatement ps = con.prepareStatement(st);
        ps.setString(1, "" + cd_cargo + "");
        ps.setString(2, ds_cargo);
       
        ps.executeUpdate();
        
        con.close();
        
      }
      catch (Exception e)
      {
        System.out.println("Erro: " + e.getMessage());
      }
    }
    
    public void criarFuncionario(int cod_func, String nome, double salario, int cd_cargo){
      try
      {
        Class.forName("com.mysql.cj.jdbc.Driver");

        Connection con;
        con = DriverManager.getConnection(url, usuario, senha);
        
        String st = "INSERT INTO tbfuncs(cod_func, nome_func, sal_func, cd_cargo) VALUES (?, ?, ?, ?)";
        PreparedStatement ps = con.prepareStatement(st);
        ps.setString(1, "" + cod_func + "");
        ps.setString(2, "" + nome + "");
        ps.setString(3, "" + salario + "");
        ps.setString(4, "" + cd_cargo + "");
       
        ps.executeUpdate();
        
        con.close();
        
      }
      catch (Exception e)
      {
        System.out.println("Erro: " + e.getMessage());
      }
    }

    
    public Funcionarios pesquisa(String nomePesquisa) {
      try
      {
        Class.forName("com.mysql.cj.jdbc.Driver");

        Connection con;
        con = DriverManager.getConnection(url, usuario, senha);
        
        String st = "SELECT nome_func, sal_func, ds_cargo FROM tbfuncs as f INNER JOIN tbcargos as c ON f.cd_cargo = c.cd_cargo WHERE nome_func LIKE ?";
        PreparedStatement ps = con.prepareStatement(st);
        ps.setString(1, "%" + nomePesquisa + "%");
        ResultSet rs = ps.executeQuery();
        
        //salvaRS(rs);

        String nome, salario, cargo;
        
        Funcionarios f = new Funcionarios();
        
        while(rs.next()){

            nome = rs.getString("nome_func");
            salario = rs.getString("sal_func");
            cargo = rs.getString("ds_cargo");
            Funcionario aux = new Funcionario(nome, salario, cargo);

            f.adicionar(aux);
        }

        con.close();
        
        
        return f;
        
      }
      catch (Exception e)
      {
        System.out.println("Erro: " + e.getMessage());
        Funcionarios f = new Funcionarios();
        return f;
      }
    }
}
