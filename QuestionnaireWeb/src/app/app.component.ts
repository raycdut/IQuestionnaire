import {Component} from '@angular/core';
import {MatIconRegistry} from '@angular/material';
import {DomSanitizer} from '@angular/platform-browser';

@Component({selector: 'app-root', templateUrl: './app.component.html', styleUrls: ['./app.component.css']})
export class AppComponent {
  title = 'app';

  constructor(private matIconRegistry: MatIconRegistry, private domSanitizer: DomSanitizer) {
    this.registryNewIcons();
  }

  registryNewIcons() {
    this
      .matIconRegistry
      .addSvgIcon('singlequestion', this.domSanitizer.bypassSecurityTrustResourceUrl('../assets/singleq-icon.svg'));
    this
      .matIconRegistry
      .addSvgIcon('multiquestion', this.domSanitizer.bypassSecurityTrustResourceUrl('../assets/multiq-icon.svg'));
    this
      .matIconRegistry
      .addSvgIcon('textquestion', this.domSanitizer.bypassSecurityTrustResourceUrl('../assets/textq-icon.svg'));
  }

}
