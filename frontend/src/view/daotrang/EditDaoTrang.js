import { UserOutlined } from "@ant-design/icons";
import { Avatar, Form, Input, Modal, Select, Space} from "antd"

const EditDaoTrang=({ open, onCreate, onCancel})=>{
    const [form] = Form.useForm();
    return <Modal
    width={700}
    open={open}
    title="Cập nhật thông tin đạo tràng"
    okText="Cập nhật"
    cancelText="Bỏ qua"
    onCancel={onCancel}   
    onOk={() => {
    }}
  >
  <div>   
    <div className="editpt">
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Nội dung</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
        <div>
            <div style={{marginBottom:'8px'}}>Địa chỉ</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
    </div>
    <div className="editpt">
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Số thành viên tham gia</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Ngày tổ chức</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
        </div>
    </div>
  </Modal>
}
export default EditDaoTrang