static class Info {
public static List<Pais> ListaPaises {get; private set;}
private static void IniciarLista() {
ListaPaises.Add(new Pais("Sudán del Sur", "bandera_sudanDelSur.png", 10750000, new DateTime(9/7/2011), "Nilo blanco, Bandiglio national park"));
}

/*
public static List<Pais> ListarPaises() {
}



public static Pais DetallePais(string Nombre) {
}
*/
}