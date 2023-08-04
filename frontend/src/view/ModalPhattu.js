import { UserOutlined } from "@ant-design/icons";
import { Avatar, Form, Input, Modal, Select, Space} from "antd"

const ModalPhattu=({ open, onCreate, onCancel})=>{
    const [form] = Form.useForm();
    return <Modal
    width={700}
    open={open}
    title="Thông tin người dùng"
    okButtonProps={{
          style: {
            display: "none",
          },
        }}
        cancelButtonProps={{
          style: {
            display: "none",
          },
        }}
    onCancel={onCancel}   
    onOk={() => {
    }}
  >
    <div>
      <div>
        <Space wrap size={16}>
        <Avatar size={64} icon={<UserOutlined />} />
        </Space>
        <div>Ảnh đại diện người dùng</div>
        
      </div>       
      <div className="editpt">
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Họ tên</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
        <div>
            <div style={{marginBottom:'8px'}}>Pháp danh</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
      </div>
      <div className="editpt">
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Email</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
        <div>
            <div style={{marginBottom:'8px'}}>Số điện thoại</div>
            <Input style={{width:'300px'}} type="text"/>
        </div>
       </div>
       <div  className="editpt">
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Ngày sinh</div>
            <Input style={{width:'300px'}} type="date"/>
        </div>
        <div>
            <div style={{marginBottom:'8px'}}>Ngày xuất gia</div>
            <Input style={{width:'300px'}} type="date"/>
        </div>
       </div>
       <div className="editpt">
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Giới tính</div>
            <Select style={{width:'200px'}}
            options={[
                {
                value: 'Nam',
                label: 'Nam',
                },
                {
                value: 'Nu',
                label: 'Nữ',
                },         
            ]}
            />
        </div>
        <div style={{marginRight:'30px'}}>
            <div style={{marginBottom:'8px'}}>Hoàn tục</div>
            <Select style={{width:'200px'}}
            options={[
                {
                value: 'dahoantuc',
                label: 'Đã hoàn tục',
                },
                {
                value: 'xuatgia',
                label: 'Xuất gia',
                },         
            ]}
            />
        </div>
        <div>
            <div style={{marginBottom:'8px'}}>Ngày hoàn tục</div>
            <Input style={{width:'200px'}} type="date"/>
        </div>
       </div>
    </div>
  </Modal>
}
export default ModalPhattu