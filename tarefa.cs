namespace EPYO.tarefa
{
	pubic class Tarefa
	{
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public DateTime DataInicio { get; set; }
		public DateTime DataEncerramento { get; set; }
		public string AtribuirTarefaUsuario { get; set; }
		public bool Status { get; set; }
	}
}
