using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TesteWebApp.ViewModels
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "O nome da role é obrigatório")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
