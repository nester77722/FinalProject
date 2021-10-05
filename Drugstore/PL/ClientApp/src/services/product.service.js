import api from './api';

class ProductService {
  getPublicContent() {
    return api.get('/test/all');
  }
}

export default new ProductService();
