import { EntityModelerTemplatePage } from './app.po';

describe('EntityModeler App', function() {
  let page: EntityModelerTemplatePage;

  beforeEach(() => {
    page = new EntityModelerTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
