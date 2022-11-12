import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormGroup, FormControl } from '@angular/forms';
import { FuncionImagenArqService } from 'src/app/Services/funcion-imagen-arq.service';
import { ImagenDiseno } from '../../../../Models/ImagenDiseno';

@Component({
  selector: 'app-editar-imgdiseno',
  templateUrl: './editar-imgdiseno.component.html',
  styleUrls: ['./editar-imgdiseno.component.css']
})
export class EditarImgdisenoComponent implements OnInit {

    constructor(private service: FuncionImagenArqService, private router: Router, private activatedRoute: ActivatedRoute) { }

    dataImgArq: ImagenDiseno;

    editarFormImgArq = new FormGroup({
        id_Imagen: new FormControl(''),
        id_Diseno: new FormControl(''),
        almacenamiento: new FormControl(''),
        error: new FormControl('')
    });

    ngOnInit() {
        let imgDisenoId = this.activatedRoute.snapshot.paramMap.get('id_Imagen');
        this.service.getImgDisenoId(imgDisenoId).subscribe(Data => {
            this.dataImgArq = Data;
            this.editarFormImgArq.patchValue({
                'id_Imagen': this.dataImgArq.id_Imagen,
                'id_Diseno': this.dataImgArq.id_Diseno,
                'almacenamiento': this.dataImgArq.almacenamiento,
            });
        });
    }

    putImgDiseno(form: ImagenDiseno) {
        this.service.putImgDiseno(form).subscribe(Data => {
            console.log(Data);
            alert("Datos Editados");
        });
        window.localStorage.reload;
        this.router.navigate(["ListarImagesarq"]);
    }

    Salir() {
        this.router.navigate(["ListarImagesarq"]);
    }
}
