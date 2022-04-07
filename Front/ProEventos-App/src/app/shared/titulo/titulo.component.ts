import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-titulo',
  templateUrl: './titulo.component.html',
  styleUrls: ['./titulo.component.scss']
})
export class TituloComponent implements OnInit {
  verificar = true;
  lista = 'Listar';
  @Input() iconClass = 'fa fa-user'
  @Input() subtitulo = 'Desde 2022';
  @Input() titulo = '';
  @Input() botaoListar = false;
  constructor(private router: Router) { }

  ngOnInit(): void {}

  listar(): void {
    // if(this.verificar == false)
    // {
      this.router.navigate([`/${this.titulo.toLocaleLowerCase()}/lista`])
      // this.lista = 'Ocultar';
      // this.verificar = true;
    // }
    // else{
      // this.verificar = false;
      // this.lista = 'Listar';
      // this.router.navigate([`/${this.titulo.toLocaleLowerCase()}`])
    }
  // }
}
