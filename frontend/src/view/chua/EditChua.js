import { UserOutlined } from "@ant-design/icons";
import { Avatar, Form, Input, Modal, Select, Space} from "antd"

const EditChua=({ open, onCreate, onCancel})=>{
    const [form] = Form.useForm();
    return <Modal
    width={700}
    open={open}
    title="Cập nhật thông tin chùa"
    okText="Cập nhật"
    cancelText="Bỏ qua"
    onCancel={onCancel}   
    onOk={() => {
    }}
  >
    <div>   
      <div className="editpt">
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Tên chùa</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
        <div>
            <div style={{marginBottom:'8px'}}>Địa chỉ</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
      </div>
      <div className="editpt">
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Ngày thành lập</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
        </div>
    </div>
  </Modal>
}
export default EditChua