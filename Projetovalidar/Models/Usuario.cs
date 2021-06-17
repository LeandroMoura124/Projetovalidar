using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using System.Web;

namespace Projetovalidar.Models
{
	public class Usuario
	{
		[Required(ErrorMessage = "O nome é obrigatório")]
		public string Nome { get; set; }

		[StringLength(50, MinimumLength = 5, ErrorMessage = "Insira de 5 a 50 caracteres.")]
		public string Observacao { get; set; }

		[Range(18, 70, ErrorMessage = "Idade permitida entre 18 e 70!")]
		public int Idade { get; set; }

		[RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
		public string Email { get; set; }

		[RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras de 5 a 15 caracteres")]
		[Required(ErrorMessage = "Login obrigatório")]
		[Remote("LoginUnico", "usuario", ErrorMessage = "Login já cadastrado")]
		public string Login { get; set; }

		[Required(ErrorMessage = "Senha obrigatório")]
		public string Senha { get; set; }

		[System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "A senha não corresponde.")]
		public string Confsenha { get; set; }


	}
}