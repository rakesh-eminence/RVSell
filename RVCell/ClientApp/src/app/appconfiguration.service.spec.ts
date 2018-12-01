import { TestBed, inject } from '@angular/core/testing';

import { AppconfigurationService } from './appconfiguration.service';

describe('AppconfigurationService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [AppconfigurationService]
    });
  });

  it('should be created', inject([AppconfigurationService], (service: AppconfigurationService) => {
    expect(service).toBeTruthy();
  }));
});
