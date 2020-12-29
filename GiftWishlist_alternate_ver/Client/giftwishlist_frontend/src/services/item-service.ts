import axios from 'axios';
import {IItem} from '@/types/Item';

export class ItemService {
    API_URL = process.env.VUE_APP_API_URL;
    async save(newItem: IItem) {
        let result:any = await axios.post(`${this.API_URL}/items/`, newItem);
        return result.data;
    }

    async delete(itemId: number){
        console.log(`delete ${this.API_URL}/items/${itemId}`);
        let result:any = await axios.patch(`${this.API_URL}/items/${itemId}`);
        return result.data;
    }
}
