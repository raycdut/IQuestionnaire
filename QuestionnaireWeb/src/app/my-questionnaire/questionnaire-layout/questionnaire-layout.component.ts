import { Component } from '@angular/core';
import { BreakpointObserver, Breakpoints, BreakpointState } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-questionnaire-layout',
  templateUrl: './questionnaire-layout.component.html',
  styleUrls: ['./questionnaire-layout.component.css']
})
export class QuestionnaireLayoutComponent {
  isHandset: Observable<BreakpointState> = this.breakpointObserver.observe(Breakpoints.Handset);
  constructor(private breakpointObserver: BreakpointObserver,
  private route: ActivatedRoute
  ) {}
}
