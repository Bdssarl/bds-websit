﻿using bds_site_web_version2_.Validations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version2_.Models
{
    [NotMapped]
    [BindRequired]
    public class UserStage
    {
        [StringLength(10,ErrorMessage ="la taille ne doit pas dépasser 10 caractères ")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string civilite { get; set; }
        public string PhoneNumber { get; set; }
        public string ObjetMessage { get; set; }
        public string TypeStage { get; set; }
        public string DomaineStage { get; set; }
        [Required]
        [StringLength(1000)]
        public string DescriptionMessage { get; set; }
        [UserStageLimitSizeFile(2,ErrorMessage = "$la taille de votre fichier ne doit pas excéder {2}Mo")]
        [UserStageValidExtension(ErrorMessage = "$veuillez inserez un fichier avec l'une des extensions suivantes:pdf ,txt")]
        public IFormFile formFile { get; set; }
    }
}
